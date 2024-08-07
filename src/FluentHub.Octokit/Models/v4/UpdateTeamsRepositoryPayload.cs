// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of UpdateTeamsRepository
	/// </summary>
	public class UpdateTeamsRepositoryPayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The repository that was updated.
		/// </summary>
		public Repository Repository { get; set; }

		/// <summary>
		/// The teams granted permission on the repository.
		/// </summary>
		public List<Team> Teams { get; set; }
	}
}
