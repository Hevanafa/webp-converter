use image::io::Reader;
use std::{path::Path, ffi::CStr, fs::OpenOptions, io::Write};
use std::ffi::c_char;

pub fn process_webp(src_name: &str, target_name: &str) {
    // Decode WEBP
    let img = Reader::open(src_name).unwrap().decode().unwrap();

    if !Path::new("log.txt").exists() {
        std::fs::File::create("log.txt").unwrap();
    }

    let mut file = OpenOptions::new()
        .append(true) // .write is set to true by default
        .open("log.txt")
        .unwrap();

    match img.save(&Path::new(target_name)) {
        Err(e) => {
            file.write(format!("Error while saving: {:?}\n", e).as_bytes()).unwrap();
        },
        Ok(_) => {
            file.write(format!("Saved as {}\n", target_name).as_bytes()).unwrap();
        }
    }
}


#[no_mangle]
pub extern fn interop_process_webp(src_filename: *const c_char, target_filename: *const c_char) -> u32 {
    // Process filenames
    let c_str = unsafe {
        assert!(!src_filename.is_null());
        CStr::from_ptr(src_filename)
    };
    let src_name = c_str.to_str().to_owned().unwrap();

    let c_str = unsafe {
        assert!(!target_filename.is_null());
        CStr::from_ptr(target_filename)
    };
    let target_name = c_str.to_str().to_owned().unwrap();

    process_webp(src_name, target_name);

    target_name.len() as u32
}
