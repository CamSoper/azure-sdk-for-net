//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch job.
    /// </summary>
    public partial class CloudJob : ITransportObjectProvider<Models.JobAddParameter>, IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<IList<EnvironmentSetting>> CommonEnvironmentSettingsProperty;
            public readonly PropertyAccessor<JobConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<DateTime?> CreationTimeProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<string> ETagProperty;
            public readonly PropertyAccessor<JobExecutionInformation> ExecutionInformationProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<JobManagerTask> JobManagerTaskProperty;
            public readonly PropertyAccessor<JobPreparationTask> JobPreparationTaskProperty;
            public readonly PropertyAccessor<JobReleaseTask> JobReleaseTaskProperty;
            public readonly PropertyAccessor<DateTime?> LastModifiedProperty;
            public readonly PropertyAccessor<IList<MetadataItem>> MetadataProperty;
            public readonly PropertyAccessor<PoolInformation> PoolInformationProperty;
            public readonly PropertyAccessor<Common.JobState?> PreviousStateProperty;
            public readonly PropertyAccessor<DateTime?> PreviousStateTransitionTimeProperty;
            public readonly PropertyAccessor<int?> PriorityProperty;
            public readonly PropertyAccessor<Common.JobState?> StateProperty;
            public readonly PropertyAccessor<DateTime?> StateTransitionTimeProperty;
            public readonly PropertyAccessor<JobStatistics> StatisticsProperty;
            public readonly PropertyAccessor<string> UrlProperty;
            public readonly PropertyAccessor<bool?> UsesTaskDependenciesProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CommonEnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>("CommonEnvironmentSettings", BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor<JobConstraints>("Constraints", BindingAccess.Read | BindingAccess.Write);
                this.CreationTimeProperty = this.CreatePropertyAccessor<DateTime?>("CreationTime", BindingAccess.None);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>("DisplayName", BindingAccess.Read | BindingAccess.Write);
                this.ETagProperty = this.CreatePropertyAccessor<string>("ETag", BindingAccess.None);
                this.ExecutionInformationProperty = this.CreatePropertyAccessor<JobExecutionInformation>("ExecutionInformation", BindingAccess.None);
                this.IdProperty = this.CreatePropertyAccessor<string>("Id", BindingAccess.Read | BindingAccess.Write);
                this.JobManagerTaskProperty = this.CreatePropertyAccessor<JobManagerTask>("JobManagerTask", BindingAccess.Read | BindingAccess.Write);
                this.JobPreparationTaskProperty = this.CreatePropertyAccessor<JobPreparationTask>("JobPreparationTask", BindingAccess.Read | BindingAccess.Write);
                this.JobReleaseTaskProperty = this.CreatePropertyAccessor<JobReleaseTask>("JobReleaseTask", BindingAccess.Read | BindingAccess.Write);
                this.LastModifiedProperty = this.CreatePropertyAccessor<DateTime?>("LastModified", BindingAccess.None);
                this.MetadataProperty = this.CreatePropertyAccessor<IList<MetadataItem>>("Metadata", BindingAccess.Read | BindingAccess.Write);
                this.PoolInformationProperty = this.CreatePropertyAccessor<PoolInformation>("PoolInformation", BindingAccess.Read | BindingAccess.Write);
                this.PreviousStateProperty = this.CreatePropertyAccessor<Common.JobState?>("PreviousState", BindingAccess.None);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>("PreviousStateTransitionTime", BindingAccess.None);
                this.PriorityProperty = this.CreatePropertyAccessor<int?>("Priority", BindingAccess.Read | BindingAccess.Write);
                this.StateProperty = this.CreatePropertyAccessor<Common.JobState?>("State", BindingAccess.None);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>("StateTransitionTime", BindingAccess.None);
                this.StatisticsProperty = this.CreatePropertyAccessor<JobStatistics>("Statistics", BindingAccess.None);
                this.UrlProperty = this.CreatePropertyAccessor<string>("Url", BindingAccess.None);
                this.UsesTaskDependenciesProperty = this.CreatePropertyAccessor<bool?>("UsesTaskDependencies", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.CloudJob protocolObject) : base(BindingState.Bound)
            {
                this.CommonEnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollectionAndFreeze(protocolObject.CommonEnvironmentSettings),
                    "CommonEnvironmentSettings",
                    BindingAccess.Read);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new JobConstraints(o)),
                    "Constraints",
                    BindingAccess.Read | BindingAccess.Write);
                this.CreationTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.CreationTime,
                    "CreationTime",
                    BindingAccess.Read);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    "DisplayName",
                    BindingAccess.Read);
                this.ETagProperty = this.CreatePropertyAccessor(
                    protocolObject.ETag,
                    "ETag",
                    BindingAccess.Read);
                this.ExecutionInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExecutionInfo, o => new JobExecutionInformation(o).Freeze()),
                    "ExecutionInformation",
                    BindingAccess.Read);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read);
                this.JobManagerTaskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.JobManagerTask, o => new JobManagerTask(o).Freeze()),
                    "JobManagerTask",
                    BindingAccess.Read);
                this.JobPreparationTaskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.JobPreparationTask, o => new JobPreparationTask(o).Freeze()),
                    "JobPreparationTask",
                    BindingAccess.Read);
                this.JobReleaseTaskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.JobReleaseTask, o => new JobReleaseTask(o).Freeze()),
                    "JobReleaseTask",
                    BindingAccess.Read);
                this.LastModifiedProperty = this.CreatePropertyAccessor(
                    protocolObject.LastModified,
                    "LastModified",
                    BindingAccess.Read);
                this.MetadataProperty = this.CreatePropertyAccessor(
                    MetadataItem.ConvertFromProtocolCollection(protocolObject.Metadata),
                    "Metadata",
                    BindingAccess.Read | BindingAccess.Write);
                this.PoolInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.PoolInfo, o => new PoolInformation(o)),
                    "PoolInformation",
                    BindingAccess.Read | BindingAccess.Write);
                this.PreviousStateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Common.JobState>(protocolObject.PreviousState),
                    "PreviousState",
                    BindingAccess.Read);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.PreviousStateTransitionTime,
                    "PreviousStateTransitionTime",
                    BindingAccess.Read);
                this.PriorityProperty = this.CreatePropertyAccessor(
                    protocolObject.Priority,
                    "Priority",
                    BindingAccess.Read | BindingAccess.Write);
                this.StateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Common.JobState>(protocolObject.State),
                    "State",
                    BindingAccess.Read);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.StateTransitionTime,
                    "StateTransitionTime",
                    BindingAccess.Read);
                this.StatisticsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Stats, o => new JobStatistics(o).Freeze()),
                    "Statistics",
                    BindingAccess.Read);
                this.UrlProperty = this.CreatePropertyAccessor(
                    protocolObject.Url,
                    "Url",
                    BindingAccess.Read);
                this.UsesTaskDependenciesProperty = this.CreatePropertyAccessor(
                    protocolObject.UsesTaskDependencies,
                    "UsesTaskDependencies",
                    BindingAccess.Read);
            }
        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJob"/> class.
        /// </summary>
        /// <param name='parentBatchClient'>The parent <see cref="BatchClient"/> to use.</param>
        /// <param name='baseBehaviors'>The base behaviors to use.</param>
        internal CloudJob(
            BatchClient parentBatchClient,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.propertyContainer = new PropertyContainer();
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
        }

        internal CloudJob(
            BatchClient parentBatchClient,
            Models.CloudJob protocolObject,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="CloudJob"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region CloudJob

        /// <summary>
        /// Gets or sets a list of common environment variable settings. These environment variables are set for all tasks 
        /// in this <see cref="CloudJob"/> (including the Job Manager, Job Preparation and Job Release tasks).
        /// </summary>
        public IList<EnvironmentSetting> CommonEnvironmentSettings
        {
            get { return this.propertyContainer.CommonEnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.CommonEnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        public JobConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets the creation time of the job.
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this.propertyContainer.CreationTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the display name of the job.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets the ETag for the job.
        /// </summary>
        public string ETag
        {
            get { return this.propertyContainer.ETagProperty.Value; }
        }

        /// <summary>
        /// Gets the execution information for the job.
        /// </summary>
        public JobExecutionInformation ExecutionInformation
        {
            get { return this.propertyContainer.ExecutionInformationProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the id of the job.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Job Manager task. The Job Manager task is launched when the <see cref="CloudJob"/> is started.
        /// </summary>
        public JobManagerTask JobManagerTask
        {
            get { return this.propertyContainer.JobManagerTaskProperty.Value; }
            set { this.propertyContainer.JobManagerTaskProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Job Preparation task. The Batch service will run the Job Preparation task on a compute node 
        /// before starting any tasks of that job on that compute node.
        /// </summary>
        public JobPreparationTask JobPreparationTask
        {
            get { return this.propertyContainer.JobPreparationTaskProperty.Value; }
            set { this.propertyContainer.JobPreparationTaskProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Job Release task. The Batch service runs the Job Release task when the job ends, on each compute 
        /// node where any task of the job has run.
        /// </summary>
        public JobReleaseTask JobReleaseTask
        {
            get { return this.propertyContainer.JobReleaseTaskProperty.Value; }
            set { this.propertyContainer.JobReleaseTaskProperty.Value = value; }
        }

        /// <summary>
        /// Gets the last modified time of the job.
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.propertyContainer.LastModifiedProperty.Value; }
        }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as metadata.
        /// </summary>
        public IList<MetadataItem> Metadata
        {
            get { return this.propertyContainer.MetadataProperty.Value; }
            set
            {
                this.propertyContainer.MetadataProperty.Value = ConcurrentChangeTrackedModifiableList<MetadataItem>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's tasks.
        /// </summary>
        public PoolInformation PoolInformation
        {
            get { return this.propertyContainer.PoolInformationProperty.Value; }
            set { this.propertyContainer.PoolInformationProperty.Value = value; }
        }

        /// <summary>
        /// Gets the previous state of the job.
        /// </summary>
        /// <remarks>
        /// If the job is in its initial <see cref="Common.JobState.Active"/> state, the PreviousState property is not defined.
        /// </remarks>
        public Common.JobState? PreviousState
        {
            get { return this.propertyContainer.PreviousStateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the job entered its previous state.
        /// </summary>
        /// <remarks>
        /// If the job is in its initial <see cref="Common.JobState.Active"/> state, the PreviousStateTransitionTime property 
        /// is not defined.
        /// </remarks>
        public DateTime? PreviousStateTransitionTime
        {
            get { return this.propertyContainer.PreviousStateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the priority of the job. Priority values can range from -1000 to 1000, with -1000 being the lowest 
        /// priority and 1000 being the highest priority.
        /// </summary>
        /// <remarks>
        /// The default value is 0.
        /// </remarks>
        public int? Priority
        {
            get { return this.propertyContainer.PriorityProperty.Value; }
            set { this.propertyContainer.PriorityProperty.Value = value; }
        }

        /// <summary>
        /// Gets the current state of the job.
        /// </summary>
        public Common.JobState? State
        {
            get { return this.propertyContainer.StateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the job entered its current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.propertyContainer.StateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets resource usage statistics for the entire lifetime of the job.
        /// </summary>
        /// <remarks>
        /// This property is populated only if the <see cref="CloudJob"/> was retrieved with an <see cref="ODATADetailLevel.ExpandClause"/> 
        /// including the 'stats' attribute; otherwise it is null.
        /// </remarks>
        public JobStatistics Statistics
        {
            get { return this.propertyContainer.StatisticsProperty.Value; }
        }

        /// <summary>
        /// Gets the URL of the job.
        /// </summary>
        public string Url
        {
            get { return this.propertyContainer.UrlProperty.Value; }
        }

        /// <summary>
        /// Gets or sets whether tasks in the job can define dependencies on each other.
        /// </summary>
        /// <remarks>
        /// The default value is false.
        /// </remarks>
        public bool? UsesTaskDependencies
        {
            get { return this.propertyContainer.UsesTaskDependenciesProperty.Value; }
            set { this.propertyContainer.UsesTaskDependenciesProperty.Value = value; }
        }

        #endregion // CloudJob

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.JobAddParameter ITransportObjectProvider<Models.JobAddParameter>.GetTransportObject()
        {
            Models.JobAddParameter result = new Models.JobAddParameter()
            {
                CommonEnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.CommonEnvironmentSettings),
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                Id = this.Id,
                JobManagerTask = UtilitiesInternal.CreateObjectWithNullCheck(this.JobManagerTask, (o) => o.GetTransportObject()),
                JobPreparationTask = UtilitiesInternal.CreateObjectWithNullCheck(this.JobPreparationTask, (o) => o.GetTransportObject()),
                JobReleaseTask = UtilitiesInternal.CreateObjectWithNullCheck(this.JobReleaseTask, (o) => o.GetTransportObject()),
                Metadata = UtilitiesInternal.ConvertToProtocolCollection(this.Metadata),
                PoolInfo = UtilitiesInternal.CreateObjectWithNullCheck(this.PoolInformation, (o) => o.GetTransportObject()),
                Priority = this.Priority,
                UsesTaskDependencies = this.UsesTaskDependencies,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}