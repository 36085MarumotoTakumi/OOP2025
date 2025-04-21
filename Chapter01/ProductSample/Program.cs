namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {
            Product karionto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(253, "大福", 250);




            //税抜き価格の表示
            Console.WriteLine(karionto.Name + "の税抜き価格は" + karionto.Price + "円です。");
            //税率額の表示
            Console.WriteLine(karionto.Name + "の税率額は" + karionto.GetTax() + "円です。");
            //税込み価格の表示
            Console.WriteLine(karionto.Name + "の税込み価格は" + karionto.GetPriceIncludeingTax() + "円です。");


            //税抜き価格の表示
            Console.WriteLine(daifuku.Name + "の税抜き価格は" + daifuku.Price + "円です。");
            //税率額の表示
            Console.WriteLine(daifuku.Name + "の税率額は" + daifuku.GetTax() + "円です。");
            //税込み価格の表示
            Console.WriteLine(daifuku.Name + "の税込み価格は" + daifuku.GetPriceIncludeingTax() + "円です。");



        }
    }
}
