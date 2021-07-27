using ApplicationCore.Interfaces;
using System.Collections.Generic;

namespace ApplicationCore.Entities.PostAggregate
{
    public class Post : BaseEntity, IAggregateRoot
    {
        public string AuthorId { get; private set; }
        public string Remarks { get; private set; }

        private readonly List<PostDetail> _postDetails = new List<PostDetail>();
        public IReadOnlyCollection<PostDetail> PostDetails => _postDetails.AsReadOnly();

        public int PostTypeId { get; private set; }
        public PostType PostType { get; private set; }

        public Post(string authorId,
            string remarks,
            int postTypeId)
        {
            AuthorId = authorId;
            Remarks = remarks;
            PostTypeId = postTypeId;
        }

        public void AddPostDetail(string name, string description)
        {
            _postDetails.Add(new PostDetail(name, description));
        }

        public void SetNewAuthorId(string identity)
        {
            AuthorId = identity;
        }
    }
}