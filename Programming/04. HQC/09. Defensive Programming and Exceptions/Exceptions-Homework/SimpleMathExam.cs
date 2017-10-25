namespace ExceptionHomework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;
        private const int BadResultProblemsSolved = 0;
        private const int AverageResultProblemsSolved = 4;
        private const int ExcelentResultProblemsSolved = 8;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved 
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinProblemsSolved || value > MaxProblemsSolved)
                {
                    throw new ArgumentException(
                        string.Format("Value of Problems solved must be between {0} and {1}", MinProblemsSolved, MaxProblemsSolved));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == BadResultProblemsSolved)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == AverageResultProblemsSolved)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else
            {
                return new ExamResult(6, 2, 6, "Excelent result: nothing done.");
            }
        }
    }
}