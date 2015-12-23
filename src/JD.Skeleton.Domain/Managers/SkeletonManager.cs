using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using JD.Skeleton.Domain.Models;

namespace JD.Skeleton.Domain.Managers
{
    public class SkeletonManager : ISkeletonManager
    {
        private readonly ILogger<SkeletonManager> _logger;
        
        public SkeletonManager(ILogger<SkeletonManager> logger)
        {
            _logger = logger;
        }
		
        public bool AddBone(Bone bone)
        {
            _logger.LogInformation("Adding bone {@Bone}", bone);
            return true;
        }

        public Bone GetBone(Guid id)
        {
            _logger.LogInformation("Getting bone with ID {0}", id.ToString());
            return null;
        }

        public IList<Bone> GetAllBones()
        {
            _logger.LogInformation("Getting all bones.");
            return null;
        }
    }
}