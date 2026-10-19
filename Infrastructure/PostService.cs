
// namespace Infrastructure;

// public class PostService
// {
//     public List<PostService> posts = new List<PostService>();

//     public List<PostService> GetPosts()
//     {
//         return posts;
//     }

//     public void AddPost(PostService post)
//     {
//         posts.Add(post);
//     }

//     public void UpdatePost(PostService post)
//     {
//         var oldPost = posts.Find(p => p.Id == post.Id);

//         if (oldPost != null)
//         {
//             oldPost.Title = post.Title;
//             oldPost.Description = post.Description;
//         }
//     }

//     public void Delete(int id)
//     {
//         var post = posts.Find(p => p.Id == id);

//         if (post != null)
//         {
//             posts.Remove(post);
//         }
//     }
// }