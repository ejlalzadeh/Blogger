﻿
namespace Blogger.Domain.CommentAggregate;
public interface ICommentRepository
{
    Task CreateAsync(Comment comment, CancellationToken cancellationToken);
    Task<Comment> GetCommentByApprovedLinkAsync(ApproveLink approveLink, CancellationToken cancellationToken);
    Task<Comment> GetCommentByIdAsync(CommentId commentId, CancellationToken cancellationToken);
    Task SaveChangesAsync(CancellationToken cancellationToken);
}