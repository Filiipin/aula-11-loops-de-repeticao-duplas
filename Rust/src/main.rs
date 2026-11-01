fn main() {
    println!("Gerador de confrontos");
    
    let mut times = vec!["Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova"];

    for i in 0..times.len() {
        println!("[{}] {}", i, times[i]);
    }
  
    println!("\nIda e volta");
    let mut total_ida_volta = 0;

    for i in 0..times.len() {
        for j in 0..times.len() {
            if i != j { 
                println!("{} x {}", times[i], times[j]);
                total_ida_volta += 1;
            }
        }
    }
    println!("Total de jogos (Ida e Volta): {}", total_ida_volta);

    println!("\n=Turno único");
    let mut total_turno_unico = 0;

    for i in 0..times.len() {
        for j in (i + 1)..times.len() {
            println!("{} x {}", times[i], times[j]);
            total_turno_unico += 1;
        }
    }
    println!("Total de jogos (Turno Único): {}", total_turno_unico);

    println!("\nAdicionando o Tombense");
    times.push("Tombense");

    println!("Nova lista de times com Tombense:");
    for i in 0..times.len() {
        println!("[{}] {}", i, times[i]);
    }
}