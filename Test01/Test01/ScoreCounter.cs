namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore("./StudentScore.csv");
        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

            List<Student> score = new List<Student>();
            //ファイルを一気に読み込み
            string[] lines = File.ReadAllLines(filePath);
            //読み込んだ行数分繰り返し
            foreach (string line in lines) {
                String[] items = line.Split(',');
                //Saleオブジェクトを生成
                Student student = new Student() {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                };
                score.Add(student);
            }
            return score;



        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerstoreScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (var score in _score) {
                if (dict.ContainsKey(score.Name)) {
                    dict[score.Subject] += score.Score;
                } else {
                    dict[score.Subject] = score.Score;
                }
            }
            return dict;
        }
    }
}
