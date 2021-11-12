use rand::{distributions::{Distribution, Uniform}, thread_rng};
use std::time::{Instant, Duration};
mod sorter;

fn main() {
    let mut start = Instant::now();
    let mut sourceArray: [u32; 9000] = generate_sample();
    let mut end: Duration = start.elapsed();
    println!("Elements count: {len}. Time elapsed: {:?}.\n\n", end, len = 9000);
    // print_array(&sourceArray, end);

    start = Instant::now();
    let (bubbleSortedArray, cmp, swp)= sorter::bubble_sort(sourceArray);
    end = start.elapsed();
    println!("Bubble sort. Time elapsed: {:?}. Compared {c} times. Swapped {s} times.\nQuality(c\\n): {q1}. Quality(m\\n): {q2}\n", end, c = cmp, s = swp, q1 = cmp/9000, q2 = swp/9000);
    // print_array(&bubbleSortedArray, end);

    start = Instant::now();
    let fpBubbleSortedArray: [u32; 9000] = sorter::fp_bubble_sort(sourceArray);
    end = start.elapsed();
    println!("FP bubble sort. Time elapsed: {:?}.\n", end);
    // print_array(&fpBubbleSortedArray, end);

    start = Instant::now();
    let (shakerSortedArray, cmp, swp) = sorter::shaker_sort(sourceArray);
    end = start.elapsed();
    // print_array(&shakerSortedArray, end);
    println!("Shaker sort. Time elapsed: {:?}. Compared {c} times. Swapped {s} times.\nQuality(c\\n): {q1}. Quality(m\\n): {q2}\n", end, c = cmp, s = swp, q1 = cmp/9000, q2 = swp/9000);
    
    start = Instant::now();
    let countingSortedArray: [u32; 9000] = sorter::counting_sort(sourceArray);
    end = start.elapsed();
    // print_array(&countingSortedArray, end);
    println!("Counting sort. Time elapsed: {:?}\n", end);

    start = Instant::now();
    let (insertionSortedArray, cmp, ins) = sorter::insertion_sort(sourceArray);
    end = start.elapsed();
    // print_array(&insertionSortedArray, end);
    println!("Insertion sort. Time elapsed: {:?}. Compared {c} times. Inserted {s} times.\nQuality(c\\n): {q1}. Quality(m\\n): {q2}\n", end, c = cmp, s = ins, q1 = cmp/9000, q2 = ins/9000);
}

fn generate_sample() -> [u32; 9000]
{
    let distribution = Uniform::new_inclusive(0, 100);
    let mut rng = thread_rng();

    [(); 9000].map(|_| distribution.sample(&mut rng))
}

fn print_array(array: &[u32], time: Duration) {
    for chunk in array.chunks(30) 
    {
        println!("{:width$?} ", chunk, width = 3);
    }
     println!("Elements count: {len}. Time elapsed: {:?}\n\n", time, len = 9000);
}