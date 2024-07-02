﻿using _0_Framework.Application;

namespace AccountManagement.Application.Contract.Role
{
	public interface IRoleApplication
	{
		OperationResult Create(CreateRole command);
		OperationResult Edit(EditRole command);
		EditRole GetDetails(long id);
		List<RoleViewModel> Search();
		List<RoleViewModel> GetRoles();
		string GetRoleNameBy(long roleId);
	}
}
