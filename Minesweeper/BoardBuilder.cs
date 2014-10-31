namespace Minesweeper
{
    public class BoardBuilder
    {
        private int width;
        private int height;

        public BoardBuilder SetWidth(int w)
        {
            width = w;
            return this;
        }

        public BoardBuilder SetHeight(int h)
        {
            height = h;
            return this;
        }

        public IBoard Build()
        {
            return new Board(width, height);
        }
    }
}