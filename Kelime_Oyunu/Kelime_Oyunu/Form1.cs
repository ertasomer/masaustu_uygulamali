using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class Form1 : Form
    {
        String[] questions; // sorular
        String[] answers; // cevaplar
        int[] randomizeQuestions; // random dizi indexleri
        private static int score; // skor değişkeni
        private static int questionIterator; // soru iteratörü
        private static int questionCounter; // soru sayacı
        private int answerLen = 0; // güncel cevap uzunluğu
        private int hintCounter; // ipucu karakter sayacı
        const char privateChar = '*'; // gizlenme karakteri
        const int hintPoint = 100; // ipucu eksiltme değeri
        const int stepPoint = 1000; // soru başına puan

        public Form1()
        {
            InitializeComponent();

            this.Text = "Kelime Oyunu"; // pencere başlığı

            questions = new String[5];
            answers = new String[5];
            
            questions[0] = "Türkiyenin Başkenti";
            answers[0] = "Ankara";

            questions[1] = "Dünyanın en derin gölü";
            answers[1] = "Baykal";

            questions[2] = "Dünya edebiyatında ilk roman nedir?";
            answers[2] = "Genji";

            questions[3] = "Geminin baş kısmının adı nedir?";
            answers[3] = "Pruva";

            questions[4] = "Kanguruların ülkesi neresidir?";
            answers[4] = "Avustralya";

            answer.Select(); // inputa focusla

            initialize(); // oyunu yapılandır
            nextQuestion(); // soru göster
        }

        /*
         * Oyun Yapılandırma Metodu
         */
        private void initialize()
        {
            questionIterator = questionCounter = 0;
            score = questions.Length * stepPoint;
            randomizeQuestions = new int[questions.Length];

            randomize();
        }

        /*
         * Soru Üretme Metodu
         */
        private void nextQuestion()
        {
            if(questionCounter == questions.Length)
            {
                finish();
                return;
            }
            questionIterator = randomizeQuestions[questionCounter];
            ++questionCounter;
            question.Text = questions[questionIterator];
            answer.Text = string.Empty;
            questionBox.Text = "Soru - " + questionCounter;
            answerBox.Text = "Cevap - " + questionCounter;
            answerLen = hintCounter = answers[questionIterator].Length;
            answerHint.Text = new string(privateChar, hintCounter);
        }

        /*
         * Soru indexlerini rastgele dağıtır ve farklı bir değişkene atar
         */
        private void randomize()
        {
            Random rand = new Random();
            randomizeQuestions = Enumerable.Range(0, randomizeQuestions.Length).OrderBy(i => rand.Next()).ToArray();
        }

        /*
         * Oyunu bitir
         */
        private void finish()
        {
            DialogResult dr = MessageBox.Show(
                "Skorunuz: " + score + ". Devam etmek istiyor musunuz?",
                "Oyun Bitti",
                MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                restart();
            } else
            {
                Close();
            }
        }

        /*
         * Oyunu yeniden başlat
         */
        private void restart()
        {
            initialize();
            nextQuestion();
        }


        /*
         * İpucu Alanını Güncelle
         */
        private void hintUpdate()
        {
            if (hintCounter < 0)
            {
                score -= stepPoint;
                nextQuestion();
            }
            else
            {
                answerHint.Text = String.Concat(answers[questionIterator].Substring(0, (answerLen - hintCounter)), new string(privateChar, hintCounter));
            }
        }

        /*
         * İpucu butonu Click Event
         */
        private void btnHint_Click(object sender, EventArgs e)
        {
            --hintCounter;
            hintUpdate();
        }

        /*
         * Cevapla butonu Click Event
         */
        private void btnDone_Click(object sender, EventArgs e)
        {
            String userAnswer = answer.Text.Trim().ToLower();
            if(userAnswer == "")
            {
                MessageBox.Show(
                    "Lütfen geçerli bir cevap giriniz!!",
                    "Uyarı!", 
                    MessageBoxButtons.OK);
                return;
            }
               

            if(answers[questionIterator].ToLower().Equals(userAnswer))
            {
                score -= (answerLen - hintCounter) * hintPoint;
                MessageBox.Show(
                    "Doğru kelimeyi buldunuz. Sırada ki soru geliyor..",
                    "Tebrikler!!", 
                    MessageBoxButtons.OK);
            } else
            {
                score -= stepPoint;
                MessageBox.Show(
                      "Kelimeyi bilemediniz. Sırada ki geliyor..",
                      "Maalesef :/",
                      MessageBoxButtons.OK);
            }
            nextQuestion();
        }
    }
}
