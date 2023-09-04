using DesafioPicPay.Domain.Notifications;
using DesafioPicPay.Domain.Validations.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioPicPay.Domain.Primitives
{
    public abstract class BaseEntity : IValidation
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        protected BaseEntity(List<Notification>? notifications)
        {
            _notifications = notifications;
        }

        private List<Notification>? _notifications;

        [Key]
        public Guid Id { get; protected init; }

        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;

            if (obj.GetType() != GetType())
                return false;

            if (obj is not BaseEntity entity)
                return false;

            return entity.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        private DateTimeOffset _createAt;

        public DateTimeOffset CreateAt
        {
            get { return _createAt; }
            set { _createAt = DateTime.UtcNow; }
        }

        private DateTimeOffset _updateAt;

        public DateTimeOffset UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

        [NotMapped]
        public IReadOnlyCollection<Notification>? Notifications => _notifications;

        protected void SetNotifications(Notification notification)
        {
            _notifications?.Add(notification);
        }

        public abstract bool IsValid();

    }
}
