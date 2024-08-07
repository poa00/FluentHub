// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of DeletePullRequestReview
	/// </summary>
	public class DeletePullRequestReviewInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The Node ID of the pull request review to delete.
		/// </summary>
		public ID PullRequestReviewId { get; set; }
	}
}
