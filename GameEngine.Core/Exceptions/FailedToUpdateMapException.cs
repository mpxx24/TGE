using System;

namespace GameEngine.Core.Exceptions {
    public class FailedToUpdateMapException : Exception {
        public FailedToUpdateMapException() {
        }

        public FailedToUpdateMapException(string message) : base(message) {
        }

        public FailedToUpdateMapException(string message, Exception ex) : base(message, ex) {
        }
    }
}