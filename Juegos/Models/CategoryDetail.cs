using Juegos.Infrastructure;

namespace Juegos.Models
{
    public class CategoryDetail : BaseEntity, IValueObject
    {
        public CategoryDetail(string title, string code, Status status, int estimatedHours, int? finishedHours, string image, int? score, string abandonComments)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Status = status;
            EstimatedHours = estimatedHours;
            FinishedHours = finishedHours;
            Image = image ?? throw new ArgumentNullException(nameof(image));
            Score = score;
            AbandonComments = abandonComments;
        }

        public string Title { get; private set; }

        public string Code { get; private set; }

        public Status Status { get; private set; } 

        public int EstimatedHours { get; private set; }

        public int? FinishedHours { get; private set; }

        public string Image { get; private set; }

        public int? Score { get; private set; }

        public string AbandonComments { get; private set; }

        public int CategoryId { get; private set; }

        public virtual Category Category { get; private set; }


        public void SetStatus(Status status) => Status = status;

        public void SetEstimatedHours(int estimatedHours) => EstimatedHours = estimatedHours;

        public void SetFinishedHours(int finishedHours) => FinishedHours = finishedHours;

        public void SetImage(string image) => Image = image;

        public void SetScore(int score) => Score = score;

        public void SetComments(string abandonComments) => AbandonComments = abandonComments;
    }
}
