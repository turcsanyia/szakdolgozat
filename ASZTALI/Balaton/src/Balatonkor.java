
public class Balatonkor {

	private String helyszin;
	private int elsoszakasz;
	private int masodikszakasz;
	private int harmadikszakasz;
	
	public Balatonkor(String helyszin, int elsoszakasz, int masodikszakasz, int harmadikszakasz) {
		super();
		this.helyszin = helyszin;
		this.elsoszakasz = elsoszakasz;
		this.masodikszakasz = masodikszakasz;
		this.harmadikszakasz = harmadikszakasz;
	}
	public String getHelyszin() {
		return helyszin;
	}
	public void setHelyszin(String helyszin) {
		this.helyszin = helyszin;
	}
	public int getElsoszakasz() {
		return elsoszakasz;
	}
	public void setElsoszakasz(int elsoszakasz) {
		this.elsoszakasz = elsoszakasz;
	}
	public int getMasodikszakasz() {
		return masodikszakasz;
	}
	public void setMasodikszakasz(int masodikszakasz) {
		this.masodikszakasz = masodikszakasz;
	}
	public int getHarmadikszakasz() {
		return harmadikszakasz;
	}
	public void setHarmadikszakasz(int harmadikszakasz) {
		this.harmadikszakasz = harmadikszakasz;
	}
	@Override
	public String toString() {
		return "Balatonkor [helyszin=" + helyszin + ", elsoszakasz=" + elsoszakasz + ", masodikszakasz="
				+ masodikszakasz + ", harmadikszakasz=" + harmadikszakasz + "]";
	}
	
			
}
