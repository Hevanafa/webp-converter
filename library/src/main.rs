// WEBP conversion utility
// By Hevanafa, 23-07-2023
// Note: This is only used for debugging
mod lib;

fn main() {
    let filename = std::env::args().nth(1).expect("Filename is required!");
    lib::process_webp(filename.as_str(), "a.png");
}