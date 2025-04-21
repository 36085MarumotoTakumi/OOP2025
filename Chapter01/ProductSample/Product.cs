namespace ProductSample {
    //商品クラス
    public class Product {
        //商品コード
        public int Code { get; private set; }
        //商品名
        public string Name { get; private set; }
        //商品価格(税抜き)
        public int Price { get; private set; }

        //消費税率は10%
        public readonly double _taxRate = 0.1;//フィールド

        //消費税額を求める
        public int GetTax() {


            return (int)(Price * _taxRate);
        }

        //コンストラクター  
        public Product(int code, String name, int Price) {
            this.Code = code;
            this.Name = name;
            this.Price = Price;
        }


        //税込み価格を求める
        public int GetPriceIncludeingTax() {
            return Price + GetTax();
        }
    }
}
