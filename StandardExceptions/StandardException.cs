using System;

namespace StandardExceptions {
	public class StandardException : Exception {
		
		public int Status { get; private set; }
		
		public StandardException (string aMessage, Exception aInnerException = null, int aStatus = 500) : base (aMessage,aInnerException) {
			Status = aStatus;
		}
	}
}
