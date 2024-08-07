// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of AddEnterpriseSupportEntitlement
	/// </summary>
	public class AddEnterpriseSupportEntitlementInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the Enterprise which the admin belongs to.
		/// </summary>
		public ID EnterpriseId { get; set; }

		/// <summary>
		/// The login of a member who will receive the support entitlement.
		/// </summary>
		public string Login { get; set; }
	}
}
