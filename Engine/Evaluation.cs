namespace Engine
{
    public class Evaluation
    {
        private double? _eval;
        private int? _mateIn;

        public double? Eval
        {
            get => _eval;
            set
            {
                if (value == null) return;

                _eval = value;
                _mateIn = null;
            }
        }

        public int? MateIn
        {
            get => _mateIn;
            set
            {
                if (value == null) return;

                _mateIn = value;
                _eval = null;
            }
        }

        public override string ToString()
        {
            if (_eval != null) return _eval.ToString();
            if (_mateIn != null) return $"#{_mateIn}";

            return "-";
        }
    }
}