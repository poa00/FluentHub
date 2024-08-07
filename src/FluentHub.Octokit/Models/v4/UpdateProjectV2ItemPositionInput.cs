// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of UpdateProjectV2ItemPosition
	/// </summary>
	public class UpdateProjectV2ItemPositionInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the Project.
		/// </summary>
		public ID ProjectId { get; set; }

		/// <summary>
		/// The ID of the item to be moved.
		/// </summary>
		public ID ItemId { get; set; }

		/// <summary>
		/// The ID of the item to position this item after. If omitted or set to null the item will be moved to top.
		/// </summary>
		public ID? AfterId { get; set; }
	}
}
