// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of UpdateProjectV2Collaborators
	/// </summary>
	public class UpdateProjectV2CollaboratorsInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the project to update the collaborators for.
		/// </summary>
		public ID ProjectId { get; set; }

		/// <summary>
		/// The collaborators to update.
		/// </summary>
		public List<ProjectV2Collaborator> Collaborators { get; set; }
	}
}
