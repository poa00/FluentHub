// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of UpdateEnterpriseTeamDiscussionsSetting
	/// </summary>
	public class UpdateEnterpriseTeamDiscussionsSettingPayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The enterprise with the updated team discussions setting.
		/// </summary>
		public Enterprise Enterprise { get; set; }

		/// <summary>
		/// A message confirming the result of updating the team discussions setting.
		/// </summary>
		public string Message { get; set; }
	}
}
