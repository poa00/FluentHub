// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of UnpinIssue
	/// </summary>
	public class UnpinIssuePayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The id of the pinned issue that was unpinned
		/// </summary>
		public ID? Id { get; set; }

		/// <summary>
		/// The issue that was unpinned
		/// </summary>
		public Issue Issue { get; set; }
	}
}
