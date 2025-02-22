﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Alterations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.Sqlite.Migrations.Alterations
{
    [DbContext(typeof(AlterationsElsaDbContext))]
    [Migration("20250222190815_V3_4")]
    partial class V3_4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "8.0.12");

            modelBuilder.Entity("Elsa.Alterations.Core.Entities.AlterationJob", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedLog")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_AlterationJob_CompletedAt");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_AlterationJob_CreatedAt");

                    b.HasIndex("PlanId")
                        .HasDatabaseName("IX_AlterationJob_PlanId");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_AlterationJob_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_AlterationJob_Status");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_AlterationJob_TenantId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_AlterationJob_WorkflowInstanceId");

                    b.ToTable("AlterationJobs", "Elsa");
                });

            modelBuilder.Entity("Elsa.Alterations.Core.Entities.AlterationPlan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedAlterations")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedWorkflowInstanceFilter")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_AlterationPlan_CompletedAt");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_AlterationPlan_CreatedAt");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_AlterationPlan_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_AlterationPlan_Status");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_AlterationPlan_TenantId");

                    b.ToTable("AlterationPlans", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}
