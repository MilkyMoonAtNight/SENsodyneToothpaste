public abstract class User
{
    public int id { get; set; }
    public string uname { get; set; }
    public string ustudentemail { get; set; }
    //encap
    private string password;
    public void SetPassworrd(string pwd) => password = pwd;
    public bool ValidatePass(string input) => password == input;
    
}
public class Student:User
{
    public int sid { get; set; }
    public string sName { get; set; }
    public string sSurname{ get; set; }
    public char sMiddleInit{ get; set; }
    public string Email { get; set; }

    //is tutor
    public bool IsTutor { get; set; }

    // If IsTutor is true
    public List<TutorModule>? TutorModules { get; set; }
    public List<LearningMaterial>? UploadedMaterials { get; set; }
    public List<PrivateThread>? TutorThreads { get; set; }
    public List<Notification>? TutorNotifications { get; set; }

    // Regular student properties
    public List<Enrollment> Enrollments { get; set; }
    public List<Topic> CreatedTopics { get; set; }
    public List<TopicSubscriber> Subscriptions { get; set; }
    public List<ForumPost> ForumPosts { get; set; }
    public List<PrivateThread> StudentThreads { get; set; }
    public List<Notification> StudentNotifications { get; set; }
}
