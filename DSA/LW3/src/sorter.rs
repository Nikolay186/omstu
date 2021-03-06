use std::convert::TryInto;

pub fn bubble_sort(mut arr: [u32; 9000]) -> ([u32; 9000], u32, u32)
{   
    let mut cmp: u32 = 0;
    let mut swp: u32 = 0;
    for i in 0..arr.len() {
        for j in 0..arr.len() - 1 - i {
            cmp += 1;
            if arr[j] > arr[j + 1] {
                arr.swap(j, j + 1);
                swp += 1;
            }
        }
    }
    (arr, cmp, swp)
}

pub fn fp_bubble_sort(mut arr: [u32; 9000]) -> [u32; 9000]
{
    for i in 0..8999
    {
        if let Some((j, _)) = arr.iter().enumerate()
                                        .skip(i)
                                        .min_by_key(|x| x.1)
                                        {
                                            arr.swap(i, j);
                                        }
    }
    arr
}

pub fn shaker_sort(mut arr: [u32; 9000]) -> ([u32; 9000], u32, u32)
{
    let mut cmp: u32 = 0;
    let mut swp: u32 = 0;
    loop 
    {
        let mut swapped: bool = false;
        for i in 0..8999
        {
            cmp += 1;
            if arr[i] > arr[i + 1]
            {
                arr.swap(i, i + 1);
                swapped = true;
                swp += 1;
            }
        }
        if !swapped { break; }

        swapped = false;
        for i in (0..8999).rev()
        {
            cmp += 1;
            if arr[i] > arr[i + 1]
            {
                arr.swap(i, i + 1);
                swapped = true;
                swp += 1;
            }
        }
        if !swapped { break; }
    }
    (arr, cmp, swp)
}

pub fn counting_sort(mut arr: [u32; 9000]) -> [u32; 9000]
{
    let mut occurences: [u32; 101] = [0; 101];

    for x in arr.iter().enumerate()
    {
        occurences[*x.1 as usize] += 1;
    }

    let mut i = 0;
    for (number, &quantity) in occurences.iter().enumerate()
    {
        for _ in 0..quantity
        {
            arr[i] = number as u32;
            i += 1;
        }
    }
    arr
}

pub fn insertion_sort(mut arr: [u32; 9000]) -> (Vec<u32>, u32, u32)
{
    let mut cmp: u32 = 0;
    let mut ins: u32 = 0;
    let mut narr: Vec<u32> = Vec::with_capacity(arr.len());

    for x in arr.iter().cloned() 
    {
        let inserted = narr.len();

        for i in 0..=inserted
        {
            cmp += 1;
            if i == inserted || narr[i] > x
            {
                narr.insert(i, x);
                ins += 1;
                break;
            }
        }
    }
    (narr, cmp, ins)
}

fn part(arr: &mut [u32], low: isize, high: isize) -> (isize, u32, u32)
{
    let root = high as usize;
    let mut i = low - 1;
    let mut j = high;
    let mut cmp = 0;
    let mut swp = 0;
    loop 
    {
        i += 1;
        cmp += 1;
        while arr[i as usize] < arr[root] { i += 1; }

        j -= 1;
        cmp += 1;
        while j >= 0 && arr[j as usize] > arr[root] { j -= 1; }

        if i >= j { break; }
        else { 
            swp += 1;
            arr.swap(i as usize, j as usize); 
        }
    }
    arr.swap(i as usize, root);
    (i, cmp, swp)
}

fn q_sort(arr: &mut [u32; 9000], low: isize, high: isize) -> ([u32; 9000], u32, u32)
{
    let mut cmp = 0;
    let mut swp = 0;
    if low < high
    {
        let (p, c, s) = part(arr, low, high);
        cmp += c;
        swp += s;
        q_sort(arr, low, p - 1);
        q_sort(arr, p + 1, high);
    }
    (*arr, cmp, swp)
}

pub fn quick_sort(arr: &mut [u32; 9000]) -> ([u32; 9000], u32, u32)
{
    let l: isize = arr.len().try_into().unwrap();
    q_sort(arr, 0, l - 1)
}