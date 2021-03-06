using System.Threading;
using System.Threading.Tasks;

namespace OrleansSandbox.LoadGenerator
{
    public static class CancellationTokenExtensions
    {
        /// <summary>
        /// Gets a task that completes when this cancellation token is cancelled.
        /// </summary>
        public static Task GetCompletionTask(this CancellationToken token)
        {
            var completion = new TaskCompletionSource<bool>();
            token.Register(() => completion.TrySetResult(true));
            return completion.Task;
        }
    }
}