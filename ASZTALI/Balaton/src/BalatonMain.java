import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Scanner;
import java.util.Set;

public class BalatonMain {
	
	public static String versenyzokszama = null ;
	public static List<Balatonkor> balList() {
		List<Balatonkor> verList = new ArrayList<>();
		try {
			List<String> allomany = Files.readAllLines(Paths.get("kerekpar.csv"));
			for (String sor : allomany.subList(1, allomany.size())) {
				versenyzokszama = allomany.get(0);
				String[] szelet = sor.split(";");
				
				Balatonkor o = new Balatonkor(szelet[0], Integer.parseInt(szelet[1]), Integer.parseInt(szelet[2]),
						Integer.parseInt(szelet[3]));
				verList.add(o);

			}

		} catch (Exception e) {
			System.err.println("Hiba a fájl beolvasásakor!");

		}

		return verList;
	}

	public static void main(String[] args) {

		List<Balatonkor> verList = balList();

		System.out.println("1. feladat: az állomány eltárolva és beolvasva.");
		/*
		 * for(Balatonkor bal: verList) { if(verList.size()>20) {
		 * System.err.println("Hiba az állományban maximum 20 sor lehet!"); } else{
		 * System.out.println(bal); } }
		 */

		System.out.println("2. feladat: " + verList.size() + " helyszínből állt a verseny.");

		// 3. feladat

		int sum = 0;
		for (Balatonkor bal : verList) {
			sum += bal.getElsoszakasz() + bal.getMasodikszakasz() + bal.getHarmadikszakasz();

		}
		System.out.println("3. feladat: A teljes versenysorozat hossza " + sum + " km");

		// 4. feladat
		System.out.println("4. feladat: ");
		Scanner beker = new Scanner(System.in);
		System.out.print("Kérem a város nevét!");
		String varos = beker.nextLine();
		int talalat = 0;
		String hiba = "Ez a város nem szerepel a verseny állomásai között.";
		for (Balatonkor bal : verList) {
			if (bal.getHelyszin().equals(varos)) {
				talalat = (bal.getElsoszakasz() + bal.getMasodikszakasz() + bal.getHarmadikszakasz());
			}
		}
		System.out.println(varos + "ban " + talalat + " km a szakaszok hossza.");

		// 5. feladat:

		int osszharomszakasz;
		Balatonkor leghosszabb = null;
		int max = Integer.MIN_VALUE;
		for (Balatonkor bal : verList) {
			osszharomszakasz = bal.getElsoszakasz() + bal.getMasodikszakasz() + bal.getHarmadikszakasz();
			if (osszharomszakasz > max) {
				max = osszharomszakasz;
				leghosszabb = bal;
			}
		}
		System.out.println("5. feladat: A leghosszabb versenytáv: " + leghosszabb.getHelyszin() + "-on van.");

		// 6.feladat:
		System.out.println("6. feladat: Az első szakaszok átlagos hossza: ");
		double elsoSzakaszOssz = 0;
		double atlag = 0;
		for (Balatonkor bal : verList) {
			elsoSzakaszOssz += bal.getElsoszakasz();

		}
		atlag = ((double) elsoSzakaszOssz / verList.size());
		System.out.println("\t" + new DecimalFormat("0.00").format(atlag) + " km");

		// 7. feladat
		
		Set<String>statisztika = new HashSet();
		System.out.println("7. feladat: " );
		double haromSzakaszSum =0;
		double szazalek= 0;
		for (Balatonkor bal : verList) {
				haromSzakaszSum = bal.getElsoszakasz()+bal.getMasodikszakasz()+bal.getHarmadikszakasz();
			     szazalek = ((double)(haromSzakaszSum/sum))*100;
			     System.out.println("\t"+bal.getHelyszin()+": "+ new DecimalFormat("0.00").format(szazalek)+" %" );
			     statisztika.add(bal.getHelyszin()+": "+ new DecimalFormat("0.00").format(szazalek)+" %");
			     
		}
		
		String fajlba = "";
		 for( String s : statisztika) {
			    fajlba += s+"\n";
			 
		 }
			try {
				Files.write(Paths.get("statisztika.txt"), fajlba.getBytes());
			} catch (IOException e) {
				System.err.println("Hiba a fájlba íráskor!");
			}
			
			//8.feladat
			
			double atlagos = (Double.parseDouble(versenyzokszama)/verList.size());
			System.out.println("8. feladat: az átlagos versenyzőszám: "+atlagos+ " fő.");
			
	}

}
