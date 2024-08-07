// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of CloseDiscussion
	/// </summary>
	public class CloseDiscussionInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// ID of the discussion to be closed.
		/// </summary>
		public ID DiscussionId { get; set; }

		/// <summary>
		/// The reason why the discussion is being closed.
		/// </summary>
		public DiscussionCloseReason? Reason { get; set; }
	}
}
