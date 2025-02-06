﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Runtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Elsa.EntityFrameworkCore.Oracle.Migrations.Runtime
{
    [DbContext(typeof(RuntimeElsaDbContext))]
    partial class RuntimeElsaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Elsa.KeyValues.Entities.SerializedKeyValuePair", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SerializedValue")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "TenantId" }, "IX_SerializedKeyValuePair_TenantId");

                    b.ToTable("KeyValuePairs", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.ActivityExecutionRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityNodeId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("ActivityTypeVersion")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<bool>("HasBookmarks")
                        .HasColumnType("BOOLEAN");

                    b.Property<string>("SerializedActivityState")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedActivityStateCompressionAlgorithm")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SerializedException")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedOutputs")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedProperties")
                        .HasColumnType("NCLOB");

                    b.Property<DateTimeOffset>("StartedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityId");

                    b.HasIndex("ActivityName")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityName");

                    b.HasIndex("ActivityNodeId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityNodeId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityType");

                    b.HasIndex("ActivityTypeVersion")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityTypeVersion");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_ActivityExecutionRecord_CompletedAt");

                    b.HasIndex("HasBookmarks")
                        .HasDatabaseName("IX_ActivityExecutionRecord_HasBookmarks");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_ActivityExecutionRecord_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_ActivityExecutionRecord_Status");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_TenantId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_ActivityExecutionRecord_WorkflowInstanceId");

                    b.HasIndex("ActivityType", "ActivityTypeVersion")
                        .HasDatabaseName("IX_ActivityExecutionRecord_ActivityType_ActivityTypeVersion");

                    b.ToTable("ActivityExecutionRecords", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.BookmarkQueueItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityInstanceId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityTypeName")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("BookmarkId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("SerializedOptions")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("StimulusHash")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ActivityInstanceId" }, "IX_BookmarkQueueItem_ActivityInstanceId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_BookmarkQueueItem_ActivityTypeName");

                    b.HasIndex(new[] { "BookmarkId" }, "IX_BookmarkQueueItem_BookmarkId");

                    b.HasIndex(new[] { "CorrelationId" }, "IX_BookmarkQueueItem_CorrelationId");

                    b.HasIndex(new[] { "CreatedAt" }, "IX_BookmarkQueueItem_CreatedAt");

                    b.HasIndex(new[] { "StimulusHash" }, "IX_BookmarkQueueItem_StimulusHash");

                    b.HasIndex(new[] { "TenantId" }, "IX_BookmarkQueueItem_TenantId");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_BookmarkQueueItem_WorkflowInstanceId");

                    b.ToTable("BookmarkQueueItems", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredBookmark", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityInstanceId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SerializedMetadata")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("NCLOB");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ActivityInstanceId" }, "IX_StoredBookmark_ActivityInstanceId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_StoredBookmark_ActivityTypeName");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash" }, "IX_StoredBookmark_ActivityTypeName_Hash");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash", "WorkflowInstanceId" }, "IX_StoredBookmark_ActivityTypeName_Hash_WorkflowInstanceId");

                    b.HasIndex(new[] { "CreatedAt" }, "IX_StoredBookmark_CreatedAt");

                    b.HasIndex(new[] { "Hash" }, "IX_StoredBookmark_Hash");

                    b.HasIndex(new[] { "TenantId" }, "IX_StoredBookmark_TenantId");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_StoredBookmark_WorkflowInstanceId");

                    b.ToTable("Bookmarks", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredTrigger", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Hash")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("NCLOB");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_StoredTrigger_Hash");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_StoredTrigger_Name");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_StoredTrigger_TenantId");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionVersionId");

                    b.ToTable("Triggers", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.WorkflowExecutionLogRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityInstanceId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityName")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityNodeId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("ActivityTypeVersion")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EventName")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Message")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ParentActivityInstanceId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<long>("Sequence")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("SerializedActivityState")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedPayload")
                        .HasColumnType("NCLOB");

                    b.Property<string>("Source")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("WorkflowVersion")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityId");

                    b.HasIndex("ActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityInstanceId");

                    b.HasIndex("ActivityName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityName");

                    b.HasIndex("ActivityNodeId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityNodeId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType");

                    b.HasIndex("ActivityTypeVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityTypeVersion");

                    b.HasIndex("EventName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_EventName");

                    b.HasIndex("ParentActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ParentActivityInstanceId");

                    b.HasIndex("Sequence")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Sequence");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_TenantId");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionVersionId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowInstanceId");

                    b.HasIndex("WorkflowVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowVersion");

                    b.HasIndex("ActivityType", "ActivityTypeVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType_ActivityTypeVersion");

                    b.HasIndex("Timestamp", "Sequence")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp_Sequence");

                    b.ToTable("WorkflowExecutionLogRecords", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.WorkflowInboxMessage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityInstanceId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<DateTimeOffset>("ExpiresAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SerializedBookmarkPayload")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SerializedInput")
                        .HasColumnType("NCLOB");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("WorkflowInstanceId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ActivityInstanceId" }, "IX_WorkflowInboxMessage_ActivityInstanceId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_WorkflowInboxMessage_ActivityTypeName");

                    b.HasIndex(new[] { "CorrelationId" }, "IX_WorkflowInboxMessage_CorrelationId");

                    b.HasIndex(new[] { "CreatedAt" }, "IX_WorkflowInboxMessage_CreatedAt");

                    b.HasIndex(new[] { "ExpiresAt" }, "IX_WorkflowInboxMessage_ExpiresAt");

                    b.HasIndex(new[] { "Hash" }, "IX_WorkflowInboxMessage_Hash");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_WorkflowInboxMessage_WorkflowInstanceId");

                    b.ToTable("WorkflowInboxMessages", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}
