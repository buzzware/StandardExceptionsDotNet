using System;

namespace StandardExceptions {
	public class FailedException : StandardException {
		public FailedException (string aMessage, Exception aInnerException=null, int aStatus = 422) : base (aMessage,aInnerException,aStatus) {
		}
	}
}