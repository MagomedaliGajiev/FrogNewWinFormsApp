using System.Windows.Forms;

namespace FrogNewWinFormsApp
{
    public partial class MainForm : Form
    {
        private int _movesCount = 0;
        private const int minMoves = 24; // Минимальное количество ходов для решения
        public MainForm()
        {
            InitializeComponent();
            SetTags();
        }

        private void SetTags()
        {
            // Устанавливаем теги для идентификации лягушек
            leftPictureBox1.Tag = "Left";
            leftPictureBox2.Tag = "Left";
            leftPictureBox3.Tag = "Left";
            leftPictureBox4.Tag = "Left";
            rightPictureBox1.Tag = "Right";
            rightPictureBox2.Tag = "Right";
            rightPictureBox3.Tag = "Right";
            rightPictureBox4.Tag = "Right";
            emptyPictureBox.Tag = "Empty";
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;

                _movesCount++;
                UpdateMovesCounter();
                CheckWin();
            }
        }

        private void UpdateMovesCounter()
        {
            Text = $"Лягушки - Ходов: {_movesCount}";
        }

        private void CheckWin()
        {
            // Собираем все PictureBox и сортируем по координате X
            var allBoxes = new List<PictureBox>
            {
                leftPictureBox1, leftPictureBox2, leftPictureBox3, leftPictureBox4,
                rightPictureBox1, rightPictureBox2, rightPictureBox3, rightPictureBox4,
                emptyPictureBox
            };

            var sortedBoxes = allBoxes.OrderBy(pb => pb.Location.X).ToList();

            // Проверяем правильную последовательность
            if (sortedBoxes[0].Tag.ToString() == "Right" &&
                sortedBoxes[1].Tag.ToString() == "Right" &&
                sortedBoxes[2].Tag.ToString() == "Right" &&
                sortedBoxes[3].Tag.ToString() == "Right" &&
                sortedBoxes[4].Tag.ToString() == "Empty" &&
                sortedBoxes[5].Tag.ToString() == "Left" &&
                sortedBoxes[6].Tag.ToString() == "Left" &&
                sortedBoxes[7].Tag.ToString() == "Left" &&
                sortedBoxes[8].Tag.ToString() == "Left")
            {
                string optimalityMessage = _movesCount == minMoves
                    ? "Это оптимальное решение!"
                    : $"Можно решить за {minMoves} ходов (вы сделали {_movesCount})";

                MessageBox.Show($"Поздравляем! Вы выиграли за {_movesCount} ходов.\n{optimalityMessage}", "Победа!");
            }
        }

        private void RestartGame()
        {
            // Сбрасываем позиции лягушек
            leftPictureBox1.Location = new Point(0, menuStrip1.Height);
            leftPictureBox2.Location = new Point(110, menuStrip1.Height);
            leftPictureBox3.Location = new Point(220, menuStrip1.Height);
            leftPictureBox4.Location = new Point(330, menuStrip1.Height);
            emptyPictureBox.Location = new Point(440, menuStrip1.Height);
            rightPictureBox1.Location = new Point(550, menuStrip1.Height);
            rightPictureBox2.Location = new Point(660, menuStrip1.Height);
            rightPictureBox3.Location = new Point(770, menuStrip1.Height);
            rightPictureBox4.Location = new Point(880, menuStrip1.Height);

            // Сбрасываем счетчик
            _movesCount = 0;
            UpdateMovesCounter();
        }

        private void ShowRules()
        {
            MessageBox.Show(
                "Цель игры: поменять местами левых и правых лягушек.\n\n" +
                "Правила:\n" +
                "1. Лягушки могут прыгать только на соседний лист\n" +
                "2. Лягушки могут перепрыгивать через одну лягушку\n" +
                "3. Минимальное количество ходов: 24\n\n" +
                "Управление: кликайте на лягушку, чтобы прыгнуть на свободный лист",
                "Правила игры"
            );
        }

        // Обработчики меню
        private void restartToolStripMenuItem_Click(object sender, EventArgs e) => RestartGame();
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e) => ShowRules();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
