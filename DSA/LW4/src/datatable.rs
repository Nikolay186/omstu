use std::{
    cmp::Ordering,
    collections::HashMap,
    fmt::Debug,
    fs::File,
    io::{BufRead, BufReader},
    iter::once,
};

#[derive(Debug, PartialEq, Eq, Clone, Copy)]
enum Kind {
    String,
    Int,
}

#[derive(Debug)]
pub struct DataTable {
    headers: Vec<String>,
    table: Vec<Vec<String>>,
    schema: HashMap<String, Kind>,
}

impl DataTable {
    pub fn from_csv(path: &str) -> Self {
        let file = File::open(path).expect("Cannot read file");
        let reader = BufReader::new(file);

        let mut lines = reader.lines().map(|line| {
            line.unwrap()
                .split(',')
                .map(ToOwned::to_owned)
                .collect::<Vec<_>>()
        });

        let head = lines.next().unwrap();
        let data: Vec<_> = lines.collect();
        let mut schema: HashMap<_, _> = HashMap::new();

        for idx in 0..head.len() {
            let record = &data[0][idx];
            let kind = if record.parse::<usize>().is_ok() {
                Kind::Int
            } else {
                Kind::String
            };
            schema.insert(head[idx].to_owned(), kind);
        }

        DataTable {
            headers: head,
            table: data,
            schema,
        }
    }

    pub fn shape(&self) {
        println!(
            "Shape(c, r): ({}, {})",
            &self.headers.len(),
            &self.table.len()
        );
    }

    pub fn headers(&self) {
        print!("Headers: ");
        for header in &self.headers {
            println!("{}, ", header);
        }
    }

    pub fn print_table(&self) {
        const CELL_WIDTH: usize = 20;
        let width = self.headers.len() * (CELL_WIDTH + 3) + 1;
        for rec in once(&self.headers).chain(&self.table) {
            for val in rec {
                print!("| {:<width$} ", val, width = CELL_WIDTH);
            }
            println!("|");
            println!("{:-<width$}", "", width = width);
        }
    }

    pub fn find(&self, condition: &str) -> DataTable {
        let mut condition_parts = condition.split_whitespace();
        let column = condition_parts.next().unwrap();
        let column_idx = self.headers.iter().position(|name| name == column).unwrap();
        let column_kind = self.schema.get::<str>(column).unwrap();

        let comp = match condition_parts.next().unwrap() {
            ">" => Ordering::is_gt,
            "<" => Ordering::is_lt,
            "==" => Ordering::is_eq,
            _ => panic!("Unknown condition"),
        };

        let value: String = if column_kind == &Kind::Int {
            condition_parts.next().unwrap().to_string()
        } else if column_kind == &Kind::String {
            let mut val = condition_parts.next().unwrap().to_string();
            val.push(' ');
            val.push_str(condition_parts.next().unwrap());
            val
        } else {
            panic!("Unsupported type");
        };

        let result: Vec<_> = if column_kind == &Kind::Int {
            self.table
                .clone()
                .into_iter()
                .filter(|row| {
                    let cell = row[column_idx].parse::<usize>().unwrap();
                    comp(cell.cmp(&value.parse::<usize>().unwrap()))
                })
                .collect()
        } else {
            self.table
                .clone()
                .into_iter()
                .filter(|row| {
                    let cell = &row[column_idx];
                    comp(cell.cmp(&value))
                })
                .collect()
        };

        DataTable {
            headers: self.headers.clone(),
            table: result,
            schema: self.schema.clone(),
        }
    }
}
