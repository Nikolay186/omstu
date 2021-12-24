#![allow(dead_code)]
mod datatable;

fn main() {
    let dt = datatable::DataTable::from_csv("1.csv");
    dt.print_table();
    let tdt = dt.find("Price == 2995152");
    println!();
    println!();
    println!();
    tdt.print_table();
}
