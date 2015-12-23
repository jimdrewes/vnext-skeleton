using System;
using System.Collections.Generic;
using JD.Skeleton.Domain.Models;

namespace JD.Skeleton.Domain.Managers
{
	public interface ISkeletonManager
	{
        IList<Bone> GetAllBones();
        Bone GetBone(Guid id);
        bool AddBone(Bone bone);
    }
}