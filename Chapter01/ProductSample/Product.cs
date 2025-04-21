namespace ProductSample {
    //���i�N���X
    public class Product {
        //���i�R�[�h
        public int Code { get; private set; }
        //���i��
        public string Name { get; private set; }
        //���i���i(�Ŕ���)
        public int Price { get; private set; }

        //����ŗ���10%
        public readonly double _taxRate = 0.1;//�t�B�[���h

        //����Ŋz�����߂�
        public int GetTax() {


            return (int)(Price * _taxRate);
        }

        //�R���X�g���N�^�[  
        public Product(int code, String name, int Price) {
            this.Code = code;
            this.Name = name;
            this.Price = Price;
        }


        //�ō��݉��i�����߂�
        public int GetPriceIncludeingTax() {
            return Price + GetTax();
        }
    }
}
