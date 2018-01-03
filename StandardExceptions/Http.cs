using System;

namespace StandardExceptions {
	public class UserErrorException : StandardException {
		public UserErrorException (string aMessage, Exception aInnerException=null, int aStatus = 400) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class UnsuccessfulException : StandardException {
		public UnsuccessfulException (string aMessage, Exception aInnerException=null, int aStatus = 422) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class InternalErrorException : StandardException {
		public InternalErrorException (string aMessage, Exception aInnerException=null, int aStatus = 500) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class ServerErrorException : StandardException {
		public ServerErrorException (string aMessage, Exception aInnerException=null, int aStatus = 500) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class NoNetworkException : StandardException {
		public NoNetworkException (string aMessage, Exception aInnerException=null, int aStatus = 410) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class NotFoundException : StandardException {
		public NotFoundException (string aMessage, Exception aInnerException=null, int aStatus = 404) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class ForbiddenException : StandardException {
		public ForbiddenException (string aMessage, Exception aInnerException=null, int aStatus = 403) : base (aMessage,aInnerException,aStatus) {
		}
	}

	public class UnauthorizedException : StandardException {
		public UnauthorizedException (string aMessage, Exception aInnerException=null, int aStatus = 401) : base (aMessage,aInnerException,aStatus) {
		}
	}
}