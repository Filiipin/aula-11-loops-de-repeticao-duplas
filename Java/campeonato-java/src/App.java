public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Gerador de confrontos:");

        String[] times = {"Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova"};
        int total = times.length; 

        int totalDeJogos = 0;

        for (int i = 0; i < total; i++) {
            for (int j = 0; j < total; j++) {
                if (i != j) {
                    System.out.println(times[i] + " x " + times[j]);
                    totalDeJogos++; 
                }
            }
        }

        System.out.println("Total de jogos: " + totalDeJogos);

        System.out.println("Turno único");
        int totalTurnoUnico = 0;

        for (int i = 0; i < times.length; i++) {
            for (int j = i + 1; j < times.length; j++) {
                System.out.println(times[i] + " x " + times[j]);
                totalTurnoUnico++;
        }
    }
    System.out.println("Total de jogos turno único: " + totalTurnoUnico);

    System.out.println("Adicionando o Tombense");

    String[] timesComTombense = new String[5];
    for (int i = 0; i < times.length; i++) {
        timesComTombense[i] = times[i];
    }

    timesComTombense[4] = "Tombense";

    for (int i = 0; i < timesComTombense.length; i++) {
        System.out.println("[" + i + "] " + timesComTombense[i]);
    }
    
    }
}