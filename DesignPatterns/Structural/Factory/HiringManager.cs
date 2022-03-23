namespace DesignPatterns.Structural.Factory;
abstract class HiringManager
{
    abstract protected IInterviewer MakeInterviewer();
    public void TakeInterview()
    {
        var interviewer = this.MakeInterviewer();
        interviewer.AskQuestions();
    }
}