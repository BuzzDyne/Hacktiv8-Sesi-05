namespace Override
{
    public class OverrideParent
    {
        public int bil1, bil2;
        public void bilangan(int a1, int a2)
        {
            bil1 = a1;
            bil2 = a2;
        }
        public virtual void pnjmlhperkalian()
        {
            System.Console.WriteLine("Overriding 1....-->");
            System.Console.WriteLine("Penjumlahan ("+this.bil1+") + ("+this.bil2+") adalah "+ (this.bil1+this.bil2));
            System.Console.WriteLine("Perkalian ("+this.bil1+") + ("+this.bil2+") adalah "+ (this.bil1*this.bil2));
        }
    }

    public class OverrideChild:OverrideParent
    {
        public override void pnjmlhperkalian()
        {
            System.Console.WriteLine("Overriding 2....-->");
            System.Console.WriteLine("Pemabagian ("+this.bil1+") + ("+this.bil2+") adalah "+ (this.bil1/this.bil2));
            System.Console.WriteLine("Pengurangan ("+this.bil1+") + ("+this.bil2+") adalah "+ (this.bil1-this.bil2));
        }
    }
}