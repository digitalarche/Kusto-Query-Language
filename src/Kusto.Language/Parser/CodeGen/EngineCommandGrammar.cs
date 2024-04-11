﻿// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// WARNING: Do not modify this file
//          This file is auto generated from the template file 'EngineCommandGrammar.tt'
//          Instead modify the corresponding input info file in the Kusto.Language.Generator project.
//          After making changes, use the right-click menu on the .tt file and select 'run custom tool'.

using System;
using System.Linq;
using System.Collections.Generic;
using Kusto.Language.Symbols;
using Kusto.Language.Syntax;
using Kusto.Language.Editor;

namespace Kusto.Language.Parsing
{
    using static Parsers<LexicalToken>;
    using static SyntaxParsers;
    using Utils;
    using System.Text;

    public class EngineCommandGrammar : CommandGrammar
    {
        public EngineCommandGrammar(GlobalState globals) : base(globals)
        {
        }

        internal override Parser<LexicalToken, Command>[] CreateCommandParsers(PredefinedRuleParsers rules)
        {
            var shape0 = CD("Role");
            var shape1 = new [] {CD(), CD(), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(CompletionHint.Literal, isOptional: true)};
            var shape2 = CD("Principal", CompletionHint.Literal);
            var shape3 = CD("SkipResults");
            var shape4 = CD("Notes", CompletionHint.Literal);
            var shape5 = CD("principal", CompletionHint.Literal);
            var shape6 = CD("notes", CompletionHint.Literal);
            var shape7 = CD("Policy", CompletionHint.Literal);
            var shape8 = new [] {CD(), CD(), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape9 = CD("policy", CompletionHint.Literal);
            var shape10 = new [] {CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal)};
            var shape11 = CD("DatabaseName", CompletionHint.Database);
            var shape12 = CD("PolicyName", CompletionHint.Literal);
            var shape13 = CD("EncodingPolicy", CompletionHint.Literal);
            var shape14 = CD("IngestionBatchingPolicy", CompletionHint.Literal);
            var shape15 = CD("ManagedIdentityPolicy", CompletionHint.Literal);
            var shape16 = CD("PropertyName", CompletionHint.None);
            var shape17 = CD("Value", CompletionHint.Literal);
            var shape18 = new [] {CD("PropertyName", CompletionHint.None), CD(), CD("Value", CompletionHint.Literal)};
            var shape19 = new [] {CD(), CD(), CD(CompletionHint.None), CD()};
            var shape20 = CD("RecoverabilityValue");
            var shape21 = new [] {CD(), CD(), CD("RecoverabilityValue")};
            var shape22 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape23 = CD("databaseName", CompletionHint.Literal);
            var shape24 = CD("MergePolicy", CompletionHint.Literal);
            var shape25 = CD("MaterializedViewName", CompletionHint.MaterializedView);
            var shape26 = CD("SoftDeleteValue", CompletionHint.Literal);
            var shape27 = new [] {CD(), CD(), CD("SoftDeleteValue", CompletionHint.Literal), CD(isOptional: true)};
            var shape28 = CD("RetentionPolicy", CompletionHint.Literal);
            var shape29 = CD("TableName", CompletionHint.Table);
            var shape30 = CD("PartitionFunction");
            var shape31 = CD("DateTimeColumn", CompletionHint.None);
            var shape32 = new [] {CD("PartitionFunction"), CD(), CD("DateTimeColumn", CompletionHint.None), CD()};
            var shape33 = CD("PartitionType");
            var shape34 = CD("PartitionName", CompletionHint.None);
            var shape35 = CD("PathSeparator", CompletionHint.Literal);
            var shape36 = CD("DataFormatKind");
            var shape37 = CD("StorageConnectionString", CompletionHint.Literal);
            var shape38 = new [] {CD(), CD(CompletionHint.Literal), CD()};
            var shape39 = CD("ColumnName", CompletionHint.Column);
            var shape40 = CD("ShardingPolicy", CompletionHint.Literal);
            var shape41 = CD("StreamingIngestionPolicy", CompletionHint.Literal);
            var shape42 = CD("PropertyValue", CompletionHint.Literal);
            var shape43 = CD("tableName", CompletionHint.Table);
            var shape44 = new [] {CD(), CD(CompletionHint.Tabular)};
            var shape45 = CD("csl");
            var shape46 = CD("MappingKind");
            var shape47 = CD("MappingName", CompletionHint.Literal);
            var shape48 = CD("MappingFormat", CompletionHint.Literal);
            var shape49 = new [] {CD("PropertyName", CompletionHint.None), CD(), CD("PropertyValue", CompletionHint.Literal)};
            var shape50 = CD("thumbprint", CompletionHint.Literal);
            var shape51 = CD("t", CompletionHint.Literal);
            var shape52 = new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD("csl")};
            var shape53 = new [] {CD(), CD(), CD(), CD(), CD("PolicyName", CompletionHint.Literal)};
            var shape54 = new [] {CD(), CD(), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)};
            var shape55 = new [] {CD(), CD(), CD(), CD(), CD("ManagedIdentityPolicy", CompletionHint.Literal)};
            var shape56 = CD("RowStorePolicy", CompletionHint.Literal);
            var shape57 = new [] {CD(), CD(), CD(), CD(), CD("RowStorePolicy", CompletionHint.Literal)};
            var shape58 = CD("HotData", CompletionHint.Literal);
            var shape59 = CD("HotIndex", CompletionHint.Literal);
            var shape60 = new [] {CD(), CD(), CD("HotData", CompletionHint.Literal), CD(), CD(), CD("HotIndex", CompletionHint.Literal)};
            var shape61 = CD("Timespan", CompletionHint.Literal);
            var shape62 = new [] {CD(), CD(), CD("Timespan", CompletionHint.Literal)};
            var shape63 = new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal)};
            var shape64 = CD("ColumnType");
            var shape65 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)};
            var shape66 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD()};
            var shape67 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("PolicyName", CompletionHint.Literal)};
            var shape68 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal)};
            var shape69 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)};
            var shape70 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ManagedIdentityPolicy", CompletionHint.Literal)};
            var shape71 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("MergePolicy", CompletionHint.Literal)};
            var shape72 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD(), CD("DataFormatKind"), CD(isOptional: true), CD(isOptional: true)};
            var shape73 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ShardingPolicy", CompletionHint.Literal)};
            var shape74 = CD("ShardsGroupingPolicy", CompletionHint.Literal);
            var shape75 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ShardsGroupingPolicy", CompletionHint.Literal)};
            var shape76 = CD("Status");
            var shape77 = CD("databaseName", CompletionHint.Database);
            var shape78 = CD("EntityGroupName", CompletionHint.EntityGroup);
            var shape79 = CD("clusterName", CompletionHint.Literal);
            var shape80 = new [] {CD(), CD(), CD("clusterName", CompletionHint.Literal), CD(), CD(), CD(), CD(), CD("databaseName", CompletionHint.Literal), CD()};
            var shape81 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Literal), CD()};
            var shape82 = CD("container", CompletionHint.Literal);
            var shape83 = CD("ColumnName", CompletionHint.None);
            var shape84 = new [] {CD("ColumnName", CompletionHint.None), CD(), CD("ColumnType")};
            var shape85 = CD("BinValue", CompletionHint.Literal);
            var shape86 = new [] {CD("PartitionFunction"), CD(), CD("DateTimeColumn", CompletionHint.None), CD(), CD("BinValue", CompletionHint.Literal), CD()};
            var shape87 = CD("StringColumn", CompletionHint.None);
            var shape88 = new [] {CD("PartitionType"), CD(isOptional: true)};
            var shape89 = new [] {CD("PartitionName", CompletionHint.None), CD(), CD()};
            var shape90 = CD("DateTimeFormat", CompletionHint.Literal);
            var shape91 = new [] {CD(), CD(), CD("DateTimeFormat", CompletionHint.Literal), CD(), CD("PartitionName", CompletionHint.None), CD()};
            var shape92 = new [] {CD(), CD(CompletionHint.Literal, isOptional: true)};
            var shape93 = new [] {CD(), CD(), CD(), CD(CompletionHint.Literal, isOptional: true), CD(), CD()};
            var shape94 = new [] {CD(), CD(), CD(), CD(CompletionHint.None), CD(), CD(isOptional: true)};
            var shape95 = CD("TableKind");
            var shape96 = CD("HashMod", CompletionHint.Literal);
            var shape97 = new [] {CD("PartitionType"), CD(), CD("PartitionFunction"), CD(), CD("StringColumn", CompletionHint.None), CD(), CD("HashMod", CompletionHint.Literal), CD()};
            var shape98 = new [] {CD(), CD("StringColumn", CompletionHint.None)};
            var shape99 = CD("CatalogExpression", CompletionHint.Literal);
            var shape100 = new [] {CD(), CD(), CD("CatalogExpression", CompletionHint.Literal)};
            var shape101 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD(), CD(), CD(), CD("TableKind"), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD("DataFormatKind"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape102 = CD("ExternalTableName", CompletionHint.None);
            var shape103 = CD("tableName", CompletionHint.ExternalTable);
            var shape104 = CD("leaderClusterMetadataPath", CompletionHint.Literal);
            var shape105 = CD("modificationKind");
            var shape106 = new [] {CD(), CD(), CD("modificationKind")};
            var shape107 = CD("dbName", CompletionHint.Database);
            var shape108 = new [] {CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal)};
            var shape109 = CD("entityListKind");
            var shape110 = CD("operationName");
            var shape111 = new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD("entityListKind"), CD("operationName"), CD(), CD(CompletionHint.None), CD()};
            var shape112 = CD("hotDataToken", CompletionHint.Literal);
            var shape113 = CD("hotIndexToken", CompletionHint.Literal);
            var shape114 = new [] {CD(), CD(), CD("hotDataToken", CompletionHint.Literal), CD(), CD(), CD("hotIndexToken", CompletionHint.Literal)};
            var shape115 = CD("hotToken", CompletionHint.Literal);
            var shape116 = new [] {CD(), CD(), CD("hotToken", CompletionHint.Literal)};
            var shape117 = CD("d2", CompletionHint.Literal);
            var shape118 = new [] {CD("d1", CompletionHint.Literal), CD(), CD("d2", CompletionHint.Literal)};
            var shape119 = CD("p", CompletionHint.Literal);
            var shape120 = new [] {CD(), CD(), CD("p", CompletionHint.Literal)};
            var shape121 = new [] {CD(isOptional: true), CD()};
            var shape122 = CD("hotWindows", isOptional: true);
            var shape123 = CD("d1", CompletionHint.Literal);
            var shape124 = new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD(), CD("modificationKind")};
            var shape125 = CD("name", CompletionHint.None);
            var shape126 = new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD(), CD(CompletionHint.None), CD(), CD(), CD(), CD(), CD("hotWindows", isOptional: true)};
            var shape127 = CD("FunctionName", CompletionHint.Function);
            var shape128 = CD("PropertyName");
            var shape129 = new [] {CD("PropertyName"), CD(), CD("PropertyValue", CompletionHint.Literal)};
            var shape130 = CD("Documentation", CompletionHint.Literal);
            var shape131 = CD("Folder", CompletionHint.Literal);
            var shape132 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD()};
            var shape133 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape134 = new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD()};
            var shape135 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD()};
            var shape136 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal)};
            var shape137 = CD("ExtentTagsRetentionPolicy", CompletionHint.Literal);
            var shape138 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)};
            var shape139 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("MergePolicy", CompletionHint.Literal)};
            var shape140 = new [] {CD("PartitionType"), CD(), CD()};
            var shape141 = new [] {CD("PartitionType"), CD(), CD("StringColumn", CompletionHint.None)};
            var shape142 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(isOptional: true), CD(), CD(), CD("DataFormatKind"), CD(isOptional: true), CD(isOptional: true)};
            var shape143 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape144 = new [] {CD("ColumnName", CompletionHint.Column), CD()};
            var shape145 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(CompletionHint.Column), CD()};
            var shape146 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("ShardingPolicy", CompletionHint.Literal)};
            var shape147 = CD("UpdatePolicy", CompletionHint.Literal);
            var shape148 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("UpdatePolicy", CompletionHint.Literal), CD(isOptional: true)};
            var shape149 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(), CD(isOptional: true)};
            var shape150 = CD("rowStoreKey", CompletionHint.Literal);
            var shape151 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD("rowStoreKey", CompletionHint.Literal), CD(isOptional: true)};
            var shape152 = CD("rowStoreName", CompletionHint.None);
            var shape153 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD("rowStoreName", CompletionHint.None), CD(isOptional: true)};
            var shape154 = new [] {CD(), CD(CompletionHint.None), CD()};
            var shape155 = new [] {CD(), CD(), CD(CompletionHint.Table), CD(), CD(isOptional: true)};
            var shape156 = CD("DocString", CompletionHint.Literal);
            var shape157 = new [] {CD("ColumnName", CompletionHint.Column), CD(), CD("DocString", CompletionHint.Literal)};
            var shape158 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(CompletionHint.Column), CD()};
            var shape159 = new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD("csl")};
            var shape160 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal), CD(isOptional: true)};
            var shape161 = CD("TableName", CompletionHint.Database);
            var shape162 = new [] {CD(), CD(), CD("TableName", CompletionHint.Database), CD(), CD(), CD("Policy", CompletionHint.Literal)};
            var shape163 = CD("Query", CompletionHint.Literal);
            var shape164 = CD("QueryOrCommand", CompletionHint.Tabular);
            var shape165 = CD("BlobContainerUrl", CompletionHint.Literal);
            var shape166 = CD("StorageAccountKey", CompletionHint.Literal);
            var shape167 = new [] {CD("BlobContainerUrl", CompletionHint.Literal), CD(), CD("StorageAccountKey", CompletionHint.Literal)};
            var shape168 = CD("Path", CompletionHint.Literal);
            var shape169 = new [] {CD(), CD(), CD("tableName", CompletionHint.Table)};
            var shape170 = CD("TableName", CompletionHint.None);
            var shape171 = CD("ExternalTableName", CompletionHint.ExternalTable);
            var shape172 = CD("Query", CompletionHint.Tabular);
            var shape173 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD(), CD(), CD(), CD("TableKind"), CD(), CD("StorageConnectionString", CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape174 = new [] {CD(), CD(), CD(CompletionHint.None)};
            var shape175 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.None), CD(), CD(CompletionHint.None), CD(), CD(), CD(), CD("TableKind"), CD(isOptional: true), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape176 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.None), CD(), CD(), CD("TableKind"), CD(), CD("StorageConnectionString", CompletionHint.Literal), CD(), CD(isOptional: true)};
            var shape177 = CD("WorkloadGroupName", CompletionHint.None);
            var shape178 = CD("WorkloadGroup", CompletionHint.Literal);
            var shape179 = new [] {CD(), CD(), CD("WorkloadGroupName", CompletionHint.None), CD("WorkloadGroup", CompletionHint.Literal)};
            var shape180 = CD("MaterializedViewName", CompletionHint.None);
            var shape181 = CD("UserName", CompletionHint.Literal);
            var shape182 = CD("DatabaseName", CompletionHint.None);
            var shape183 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)};
            var shape184 = CD("EntityGroupName", CompletionHint.None);
            var shape185 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal)};
            var shape186 = CD("FunctionName", CompletionHint.None);
            var shape187 = new [] {CD(), CD(), CD(isOptional: true)};
            var shape188 = new [] {CD("TableName", CompletionHint.None), CD()};
            var shape189 = new [] {CD(), CD(), CD(CompletionHint.None), CD(isOptional: true)};
            var shape190 = new [] {CD(), CD(), CD("TableName", CompletionHint.None), CD(), CD(isOptional: true)};
            var shape191 = new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD()};
            var shape192 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD()};
            var shape193 = CD("name", CompletionHint.MaterializedView);
            var shape194 = new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.None), CD(), CD(), CD()};
            var shape195 = CD("name", CompletionHint.Table);
            var shape196 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD()};
            var shape197 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD()};
            var shape198 = CD("AppName", CompletionHint.Literal);
            var shape199 = new [] {CD(), CD("AppName", CompletionHint.Literal)};
            var shape200 = new [] {CD(), CD("UserName", CompletionHint.Literal)};
            var shape201 = CD("ContinuousExportName", CompletionHint.None);
            var shape202 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(CompletionHint.Literal, isOptional: true)};
            var shape203 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD()};
            var shape204 = CD("d", CompletionHint.Literal);
            var shape205 = CD("TrimSize", CompletionHint.Literal);
            var shape206 = new [] {CD(), CD(), CD(), CD("TrimSize", CompletionHint.Literal), CD()};
            var shape207 = CD("LimitCount", CompletionHint.Literal);
            var shape208 = new [] {CD(), CD("LimitCount", CompletionHint.Literal)};
            var shape209 = CD("Older", CompletionHint.Literal);
            var shape210 = CD("ExtentId", CompletionHint.Literal);
            var shape211 = new [] {CD(), CD("TableName", CompletionHint.Table)};
            var shape212 = CD("externalTableName", CompletionHint.ExternalTable);
            var shape213 = new [] {CD(), CD(), CD(), CD("externalTableName", CompletionHint.ExternalTable), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(CompletionHint.Literal, isOptional: true)};
            var shape214 = CD("serviceType", CompletionHint.Literal);
            var shape215 = new [] {CD(), CD(), CD(), CD("serviceType", CompletionHint.Literal), CD()};
            var shape216 = CD("operationRole");
            var shape217 = new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(CompletionHint.Literal, isOptional: true)};
            var shape218 = new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD()};
            var shape219 = CD("materializedViewName", CompletionHint.MaterializedView);
            var shape220 = new [] {CD(), CD(), CD("materializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)};
            var shape221 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView)};
            var shape222 = new [] {CD(), CD(), CD("rowStoreName", CompletionHint.None), CD(isOptional: true)};
            var shape223 = CD("containerId", CompletionHint.Literal);
            var shape224 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD("Role"), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(CompletionHint.Literal, isOptional: true)};
            var shape225 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD()};
            var shape226 = new [] {CD(), CD(), CD("ContinuousExportName", CompletionHint.None)};
            var shape227 = new [] {CD(), CD(), CD(), CD(isOptional: true), CD(), CD(CompletionHint.Tabular)};
            var shape228 = new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)};
            var shape229 = CD("Data", CompletionHint.None);
            var shape230 = CD("GUID", CompletionHint.Literal);
            var shape231 = CD("SourceTableName", CompletionHint.Table);
            var shape232 = CD("DestinationTableName", CompletionHint.Table);
            var shape233 = CD("NewColumnName", CompletionHint.None);
            var shape234 = CD("NewTableName", CompletionHint.None);
            var shape235 = CD("ExtentsToDropQuery", CompletionHint.Tabular);
            var shape236 = CD("ExtentsToMoveQuery", CompletionHint.Tabular);
            var shape237 = CD("StoredQueryResultName", CompletionHint.None);
            var shape238 = new [] {CD(), CD(isOptional: true), CD("TableName", CompletionHint.None), CD(isOptional: true), CD(), CD("QueryOrCommand", CompletionHint.Tabular)};
            var shape239 = new [] {CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(CompletionHint.Literal, isOptional: true)};
            var shape240 = new [] {CD(), CD(isOptional: true)};
            var shape241 = CD("viewName", CompletionHint.MaterializedView);
            var shape242 = CD("Tag", CompletionHint.Literal);
            var shape243 = new [] {CD(), CD(), CD("Tag", CompletionHint.Literal)};
            var shape244 = new [] {CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()};
            var shape245 = new [] {CD(), CD(), CD(), CD(), CD(isOptional: true)};
            var shape246 = new [] {CD(), CD(), CD("ContinuousExportName", CompletionHint.None), CD()};
            var shape247 = CD("Version", CompletionHint.Literal);
            var shape248 = new [] {CD(), CD("Version", CompletionHint.Literal)};
            var shape249 = new [] {CD("DatabaseName", CompletionHint.Database), CD(isOptional: true)};
            var shape250 = new [] {CD(), CD(CompletionHint.Database)};
            var shape251 = new [] {CD(), CD(), CD(), CD(isOptional: true)};
            var shape252 = CD("DatabaseName");
            var shape253 = new [] {CD(), CD(), CD("DatabaseName"), CD(), CD()};
            var shape254 = new [] {CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)};
            var shape255 = new [] {CD(), CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)};
            var shape256 = new [] {CD(), CD(), CD(), CD(), CD(), CD(isOptional: true)};
            var shape257 = CD("name", CompletionHint.Literal);
            var shape258 = CD("databaseVersion", CompletionHint.Literal);
            var shape259 = new [] {CD(), CD("databaseVersion", CompletionHint.Literal)};
            var shape260 = new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD(isOptional: true)};
            var shape261 = new [] {CD(), CD(), CD(), CD(), CD("Version", CompletionHint.Literal), CD(), CD(), CD(), CD(isOptional: true)};
            var shape262 = CD("obj", CompletionHint.Literal);
            var shape263 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(isOptional: true), CD(isOptional: true)};
            var shape264 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD()};
            var shape265 = new [] {CD("Principal", CompletionHint.Literal), CD()};
            var shape266 = new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD()};
            var shape267 = new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(isOptional: true), CD(), CD(), CD(), CD(isOptional: true)};
            var shape268 = CD("Scope");
            var shape269 = new [] {CD(), CD(), CD(), CD(), CD("Scope"), CD()};
            var shape270 = new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.EntityGroup)};
            var shape271 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD()};
            var shape272 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD("MappingName", CompletionHint.Literal)};
            var shape273 = new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable)};
            var shape274 = new [] {CD(), CD(CompletionHint.Database), CD()};
            var shape275 = new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function)};
            var shape276 = new [] {CD(), CD(), CD("MappingKind"), CD(), CD(isOptional: true)};
            var shape277 = new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD()};
            var shape278 = new [] {CD(), CD(), CD("viewName", CompletionHint.MaterializedView), CD(), CD(isOptional: true)};
            var shape279 = new [] {CD(), CD(), CD("viewName", CompletionHint.MaterializedView), CD()};
            var shape280 = CD("OperationId", CompletionHint.Literal);
            var shape281 = CD("queryText");
            var shape282 = new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD()};
            var shape283 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(isOptional: true)};
            var shape284 = CD("ShardsGroupId", CompletionHint.Literal);
            var shape285 = new [] {CD(), CD(), CD("TableName", CompletionHint.Table)};
            var shape286 = CD("eid", CompletionHint.Literal);
            var shape287 = CD("tableName", CompletionHint.None);

            Func<Source<LexicalToken>, int, SyntaxElement> missing0 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral(source, start)));
            Func<Source<LexicalToken>, int, SyntaxElement> missing1 = (source, start) => (SyntaxElement)new CustomNode(shape44, CreateMissingToken("<|"), rules.MissingExpression(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing2 = (source, start) => (SyntaxElement)new CustomNode(shape38, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral(source, start))), CreateMissingToken(")"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing3 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape18, rules.MissingNameDeclaration(source, start), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing4 = (source, start) => (SyntaxElement)new CustomNode(shape21, CreateMissingToken("recoverability"), CreateMissingToken("="), CreateMissingToken("disabled", "enabled"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing5 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape80, CreateMissingToken("cluster"), CreateMissingToken("("), rules.MissingStringLiteral(source, start), CreateMissingToken(")"), CreateMissingToken("."), CreateMissingToken("database"), CreateMissingToken("("), rules.MissingStringLiteral(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing6 = (source, start) => (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing7 = (source, start) => (SyntaxElement)new CustomNode(shape140, CreateMissingToken("datetime"), CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")));
            Func<Source<LexicalToken>, int, SyntaxElement> missing8 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape140, CreateMissingToken("datetime"), CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing9 = (source, start) => new SyntaxList<SyntaxElement>((SyntaxElement)new CustomNode(shape92, (SyntaxElement)new CustomNode(shape91, CreateMissingToken("datetime_pattern"), CreateMissingToken("("), rules.MissingStringLiteral(source, start), CreateMissingToken(","), rules.MissingNameDeclaration(source, start), CreateMissingToken(")")), rules.MissingStringLiteral(source, start)));
            Func<Source<LexicalToken>, int, SyntaxElement> missing10 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape144, rules.MissingNameReference(source, start), CreateMissingToken("asc", "desc"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing11 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape49, rules.MissingNameDeclaration(source, start), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing12 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape84, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), rules.MissingType(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing13 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("docstring"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing14 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape157, rules.MissingNameReference(source, start), CreateMissingToken(":"), rules.MissingStringLiteral(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing15 = (source, start) => CreateMissingToken("*");
            Func<Source<LexicalToken>, int, SyntaxElement> missing16 = (source, start) => (SyntaxElement)new CustomNode(shape60, CreateMissingToken("hotdata"), CreateMissingToken("="), rules.MissingValue(source, start), CreateMissingToken("hotindex"), CreateMissingToken("="), rules.MissingValue(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing17 = (source, start) => (SyntaxElement)new CustomNode(shape167, rules.MissingStringLiteral(source, start), CreateMissingToken(";"), rules.MissingStringLiteral(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing18 = (source, start) => CreateMissingToken("disable");
            Func<Source<LexicalToken>, int, SyntaxElement> missing19 = (source, start) => (SyntaxElement)new CustomNode(new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape80, CreateMissingToken("cluster"), CreateMissingToken("("), rules.MissingStringLiteral(source, start), CreateMissingToken(")"), CreateMissingToken("."), CreateMissingToken("database"), CreateMissingToken("("), rules.MissingStringLiteral(source, start), CreateMissingToken(")")))), CreateMissingToken(")"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing20 = (source, start) => (SyntaxElement)new CustomNode(new [] {CD(), CD("hours", CompletionHint.Literal), CD()}, CreateMissingToken("older"), rules.MissingValue(source, start), CreateMissingToken("hours"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing21 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing22 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing23 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing24 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing25 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing26 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing27 = (source, start) => (SyntaxElement)new CustomNode(new [] {CD(), CD("serviceToNode", CompletionHint.Literal)}, CreateMissingToken("assignments"), rules.MissingStringLiteral(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing28 = (source, start) => (SyntaxElement)new CustomNode(new [] {CD(), CD(), CD("databaseNamePrefix", CompletionHint.None)}, CreateMissingToken("database-name-prefix"), CreateMissingToken("="), rules.MissingNameDeclaration(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing29 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameDeclaration(source, start)));
            Func<Source<LexicalToken>, int, SyntaxElement> missing30 = (source, start) => (SyntaxElement)new CustomNode(shape114, CreateMissingToken("hotdata"), CreateMissingToken("="), rules.MissingValue(source, start), CreateMissingToken("hotindex"), CreateMissingToken("="), rules.MissingValue(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing31 = (source, start) => (SyntaxElement)new CustomNode(shape118, rules.MissingValue(source, start), CreateMissingToken(".."), rules.MissingValue(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing32 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("dimensionMaterializedViews"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing33 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameReference(source, start)));
            Func<Source<LexicalToken>, int, SyntaxElement> missing34 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(new [] {CD("ColumnName", CompletionHint.None), CD()}, rules.MissingNameDeclaration(source, start), CreateMissingToken("asc", "desc"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing35 = (source, start) => (SyntaxElement)new CustomNode(shape154, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape84, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), rules.MissingType(source, start)))), CreateMissingToken(")"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing36 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("creationTime"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing37 = (source, start) => (SyntaxElement)new CustomNode(new [] {CD(), CD(CompletionHint.Table), CD()}, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingNameReference(source, start))), CreateMissingToken(")"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing38 = (source, start) => new SyntaxList<SyntaxElement>(rules.MissingValue(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing39 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape188, rules.MissingNameDeclaration(source, start), (SyntaxElement)new CustomNode(shape154, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape84, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), rules.MissingType(source, start)))), CreateMissingToken(")")))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing40 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing41 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing42 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing43 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing44 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing45 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing46 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("autoUpdateSchema"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing47 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing48 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing49 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing50 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing51 = (source, start) => (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")"))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing52 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape89, rules.MissingNameDeclaration(source, start), CreateMissingToken(":"), (SyntaxElement)new CustomNode(shape88, CreateMissingToken("datetime"), (SyntaxElement)new CustomNode(CreateMissingToken("="), (SyntaxElement)new CustomNode(shape86, CreateMissingToken("bin"), CreateMissingToken("("), rules.MissingNameDeclaration(source, start), CreateMissingToken(","), rules.MissingValue(source, start), CreateMissingToken(")")))))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing53 = (source, start) => (SyntaxElement)new CustomNode(CreateMissingToken("all"), CreateMissingToken("tables"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing54 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingValue(source, start)));
            Func<Source<LexicalToken>, int, SyntaxElement> missing55 = (source, start) => (SyntaxElement)new CustomNode(CreateMissingToken("all"), CreateMissingToken("tables"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing56 = (source, start) => (SyntaxElement)new CustomNode(CreateMissingToken("all"), CreateMissingToken("tables"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing57 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("ContinueOnErrors"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing58 = (source, start) => (SyntaxElement)new CustomNode(new [] {CD(), CD("Data", CompletionHint.None), CD()}, CreateMissingToken("["), rules.MissingInputText(source, start), CreateMissingToken("]"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing59 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(new [] {CD("NewColumnName", CompletionHint.None), CD(), CD("ColumnName", CompletionHint.Column)}, rules.MissingNameDeclaration(source, start), CreateMissingToken("="), rules.MissingNameReference(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing60 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(new [] {CD("NewTableName", CompletionHint.None), CD(), CD("TableName", CompletionHint.Table)}, rules.MissingNameDeclaration(source, start), CreateMissingToken("="), rules.MissingNameReference(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing61 = (source, start) => (SyntaxElement)new CustomNode(shape239, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral(source, start))), CreateMissingToken(")"), CreateMissingToken("skip-results"), rules.MissingStringLiteral(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing62 = (source, start) => (SyntaxElement)new CustomNode(new [] {CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)}, CreateMissingToken("("), new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>(rules.MissingStringLiteral(source, start))), CreateMissingToken(")"), rules.MissingStringLiteral(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing63 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape243, CreateMissingToken("tags"), CreateMissingToken("!contains", "!has", "contains", "has"), rules.MissingStringLiteral(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing64 = (source, start) => CreateMissingToken("roles");
            Func<Source<LexicalToken>, int, SyntaxElement> missing65 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape249, rules.MissingNameReference(source, start), (SyntaxElement)new CustomNode(shape248, CreateMissingToken("if_later_than"), rules.MissingStringLiteral(source, start)))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing66 = (source, start) => (SyntaxElement)new CustomNode(shape92, CreateMissingToken("operations"), rules.MissingValue(source, start));
            Func<Source<LexicalToken>, int, SyntaxElement> missing67 = (source, start) => (SyntaxElement)new CustomNode(CreateMissingToken("corrupted"), CreateMissingToken("datetime"));
            Func<Source<LexicalToken>, int, SyntaxElement> missing68 = (source, start) => (SyntaxElement)new CustomNode(shape240, CreateMissingToken("databases"), (SyntaxElement)new CustomNode(shape274, CreateMissingToken("("), SyntaxList<SeparatedElement<SyntaxElement>>.Empty(), CreateMissingToken(")")));
            Func<Source<LexicalToken>, int, SyntaxElement> missing69 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("reconstructCsl"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing70 = (source, start) => new SyntaxList<SeparatedElement<SyntaxElement>>(new SeparatedElement<SyntaxElement>((SyntaxElement)new CustomNode(shape129, CreateMissingToken("from"), CreateMissingToken("="), rules.MissingValue(source, start))));
            Func<Source<LexicalToken>, int, SyntaxElement> missing71 = (source, start) => (SyntaxElement)new CustomNode(CreateMissingToken("corrupted"), CreateMissingToken("datetime"));

            var fragment0 = Custom(
                    rules.NameDeclaration,
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape18);
            var fragment1 = Custom(
                    Token("recoverability"),
                    RequiredToken("="),
                    RequiredToken("disabled", "enabled"),
                    shape21);
            var fragment2 = Custom(
                    Token("softdelete"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    Optional(
                        fragment1),
                    shape27);
            var fragment3 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape37),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    shape38);
            var fragment4 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment0),
                        missing3),
                    RequiredToken(")"),
                    shape19);
            var fragment5 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    ZeroOrMoreCommaList(
                        fragment0),
                    RequiredToken(")"),
                    shape19);
            var fragment6 = Custom(
                    Token("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape44);
            var fragment7 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape49)),
                        missing11),
                    RequiredToken(")"),
                    shape19);
            var fragment8 = Custom(
                    Token("hotdata"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken("hotindex"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape60);
            var fragment9 = Custom(
                    Token("hot"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape62);
            var fragment10 = Custom(
                    Token("cluster"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(")"),
                    RequiredToken("."),
                    RequiredToken("database"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(")"),
                    shape80);
            var fragment11 = Custom(
                    Token("database"),
                    RequiredToken("("),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken(")"),
                    shape81);
            var fragment12 = Custom(
                    rules.NameDeclaration,
                    RequiredToken(":"),
                    Required(rules.Type, rules.MissingType),
                    shape84);
            var fragment13 = Custom(
                    Token("bin"),
                    RequiredToken("("),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken(","),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken(")"),
                    shape86);
            var fragment14 = Custom(
                    Token("startofday"),
                    RequiredToken("("),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken(")"),
                    shape32);
            var fragment15 = Custom(
                    Token("startofmonth"),
                    RequiredToken("("),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken(")"),
                    shape32);
            var fragment16 = Custom(
                    Token("startofweek"),
                    RequiredToken("("),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken(")"),
                    shape32);
            var fragment17 = Custom(
                    Token("startofyear"),
                    RequiredToken("("),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken(")"),
                    shape32);
            var fragment18 = Custom(
                    Token("pathformat"),
                    RequiredToken("="),
                    RequiredToken("("),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape35)),
                    Required(
                        OneOrMoreList(
                            Custom(
                                First(
                                    Custom(
                                        Token("datetime_pattern"),
                                        RequiredToken("("),
                                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                                        RequiredToken(","),
                                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                        RequiredToken(")"),
                                        shape91),
                                    Custom(
                                        If(Not(Token("datetime_pattern")), rules.NameDeclaration),
                                        shape34)),
                                Optional(
                                    Custom(
                                        rules.StringLiteral,
                                        shape35)),
                                shape92)),
                        missing9),
                    RequiredToken(")"),
                    shape93);
            var fragment19 = Custom(
                    Token("partition"),
                    RequiredToken("by"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken(":"),
                                Required(
                                    First(
                                        Custom(
                                            Token("datetime"),
                                            Optional(
                                                Custom(
                                                    Token("="),
                                                    Required(
                                                        First(
                                                            fragment13,
                                                            fragment14,
                                                            fragment15,
                                                            fragment16,
                                                            fragment17),
                                                        missing6))),
                                            shape88),
                                        Custom(
                                            Token("long"),
                                            RequiredToken("="),
                                            RequiredToken("hash"),
                                            RequiredToken("("),
                                            Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                            RequiredToken(","),
                                            Required(rules.Value, rules.MissingValue),
                                            RequiredToken(")"),
                                            shape97),
                                        Custom(
                                            Token("string"),
                                            Optional(
                                                Custom(
                                                    Token("="),
                                                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                                    shape98)),
                                            shape88)),
                                    missing23),
                                shape89)),
                        missing24),
                    RequiredToken(")"),
                    Optional(
                        fragment18),
                    shape94);
            var fragment20 = Custom(
                    Token("catalog"),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape100);
            var fragment21 = Custom(
                    Token("from"),
                    rules.StringLiteral,
                    shape108);
            var fragment22 = Custom(
                    Token("from"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape108);
            var fragment23 = Custom(
                    Token("hotdata"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken("hotindex"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape114);
            var fragment24 = Custom(
                    Token("hot"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape116);
            var fragment25 = Custom(
                    Optional(Token(",")),
                    OneOrMoreCommaList(
                        Custom(
                            Token("hot_window"),
                            RequiredToken("="),
                            Required(
                                Custom(
                                    rules.Value,
                                    RequiredToken(".."),
                                    Required(rules.Value, rules.MissingValue),
                                    shape118),
                                missing31),
                            shape120)),
                    shape121);
            var fragment26 = Custom(
                    First(
                        Token("dimensionMaterializedViews"),
                        Token("dimensionTables"),
                        Token("lookback"),
                        If(Not(And(Token("dimensionMaterializedViews", "dimensionTables", "lookback"))), rules.NameDeclaration)),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape129);
            var fragment27 = Custom(
                    Token("partition"),
                    RequiredToken("by"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken(":"),
                                Required(
                                    First(
                                        Custom(
                                            Token("datetime"),
                                            RequiredToken("="),
                                            Required(
                                                First(
                                                    fragment13,
                                                    fragment14,
                                                    fragment15,
                                                    fragment16,
                                                    fragment17),
                                                missing6),
                                            shape140),
                                        Custom(
                                            Token("string"),
                                            RequiredToken("="),
                                            Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                            shape141)),
                                    missing7),
                                shape89)),
                        missing8),
                    RequiredToken(")"),
                    Optional(
                        fragment18),
                    shape94);
            var fragment28 = Custom(
                    rules.ColumnNameReference,
                    RequiredToken("asc", "desc"),
                    shape144);
            var fragment29 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment12),
                        missing12),
                    RequiredToken(")"),
                    shape154);
            var fragment30 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    Token("docstring"),
                                    Token("folder"),
                                    If(Not(And(Token("docstring", "folder"))), rules.NameDeclaration)),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape129)),
                        missing13),
                    RequiredToken(")"));
            var fragment31 = Custom(
                    rules.ColumnNameReference,
                    RequiredToken(":"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape157);
            var fragment32 = Custom(
                    rules.StringLiteral,
                    Token(";"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape167);
            var fragment33 = Custom(
                    Token("into"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    shape169);
            var fragment34 = Custom(
                    Token("table"),
                    RequiredToken("="),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape174);
            var fragment35 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    Token("autoUpdateSchema"),
                                    Token("backfill"),
                                    Token("dimensionMaterializedViews"),
                                    Token("dimensionTables"),
                                    Token("docString"),
                                    Token("effectiveDateTime"),
                                    Token("folder"),
                                    Token("lookback"),
                                    Token("updateExtentsCreationTime"),
                                    If(Not(And(Token("autoUpdateSchema", "backfill", "dimensionMaterializedViews", "dimensionTables", "docString", "effectiveDateTime", "folder", "lookback", "updateExtentsCreationTime"))), rules.NameDeclaration)),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape129)),
                        missing46),
                    RequiredToken(")"));
            var fragment36 = Custom(
                    rules.NameDeclaration,
                    Required(
                        fragment29,
                        missing35),
                    shape188);
            var fragment37 = Custom(
                    Token("application"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape199);
            var fragment38 = Custom(
                    Token("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape200);
            var fragment39 = Custom(
                    Token("all"),
                    RequiredToken("tables"));
            var fragment40 = Custom(
                    Token("trim"),
                    RequiredToken("by"),
                    RequiredToken("datasize", "extentsize"),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken("bytes", "GB", "MB"),
                    shape206);
            var fragment41 = Custom(
                    Token("limit"),
                    Required(rules.Value, rules.MissingValue),
                    shape208);
            var fragment42 = Custom(
                    Token("from"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    shape211);
            var fragment43 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    Token("ContinueOnErrors"),
                                    Token("ThrowOnErrors"),
                                    If(Not(And(Token("ContinueOnErrors", "ThrowOnErrors"))), rules.NameDeclaration)),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape129)),
                        missing57),
                    RequiredToken(")"));
            var fragment44 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    Token("creationTime"),
                                    Token("distributed"),
                                    Token("docstring"),
                                    Token("extend_schema"),
                                    Token("folder"),
                                    Token("format"),
                                    Token("ignoreFirstRecord"),
                                    Token("ingestIfNotExists"),
                                    Token("ingestionMappingReference"),
                                    Token("ingestionMapping"),
                                    Token("persistDetails"),
                                    Token("policy_ingestionTime"),
                                    Token("recreate_schema"),
                                    Token("small_dimension_table"),
                                    Token("tags"),
                                    Token("validationPolicy"),
                                    Token("zipPattern"),
                                    If(Not(And(Token("creationTime", "distributed", "docstring", "extend_schema", "folder", "format", "ignoreFirstRecord", "ingestIfNotExists", "ingestionMappingReference", "ingestionMapping", "persistDetails", "policy_ingestionTime", "recreate_schema", "small_dimension_table", "tags", "validationPolicy", "zipPattern"))), rules.NameDeclaration)),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                shape129)),
                        missing36),
                    RequiredToken(")"));
            var fragment45 = Custom(
                    First(
                        Token("creationTime"),
                        Token("distributed"),
                        Token("docstring"),
                        Token("extend_schema"),
                        Token("folder"),
                        Token("format"),
                        Token("ignoreFirstRecord"),
                        Token("ingestIfNotExists"),
                        Token("ingestionMappingReference"),
                        Token("ingestionMapping"),
                        Token("persistDetails"),
                        Token("policy_ingestionTime"),
                        Token("recreate_schema"),
                        Token("small_dimension_table"),
                        Token("tags"),
                        Token("validationPolicy"),
                        Token("zipPattern"),
                        If(Not(And(Token("creationTime", "distributed", "docstring", "extend_schema", "folder", "format", "ignoreFirstRecord", "ingestIfNotExists", "ingestionMappingReference", "ingestionMapping", "persistDetails", "policy_ingestionTime", "recreate_schema", "small_dimension_table", "tags", "validationPolicy", "zipPattern"))), rules.NameDeclaration)),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    shape129);
            var fragment46 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape168),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    shape38);
            var fragment47 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    RequiredToken("rebuild"),
                    RequiredToken("="),
                    RequiredToken("true"),
                    RequiredToken(")"));
            var fragment48 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape239);
            var fragment49 = Custom(
                    Token("none"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    shape240);
            var fragment50 = Custom(
                    Token("tags"),
                    RequiredToken("!contains", "!has", "contains", "has"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape243);
            var fragment51 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    RequiredToken("extentsShowFilteringRuntimePolicy"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken(")"),
                    shape244);
            var fragment52 = Custom(
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape210),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    shape38);
            var fragment53 = Custom(
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape210),
                        fnMissingElement: rules.MissingValue),
                    Token(")"),
                    shape38);
            var fragment54 = Custom(
                    Token("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63));
            var fragment55 = Custom(
                    rules.DatabaseNameReference,
                    Optional(
                        Custom(
                            Token("if_later_than"),
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            shape248)),
                    shape249);
            var fragment56 = Custom(
                    rules.DatabaseNameReference,
                    Optional(
                        Custom(
                            Token("if_later_than"),
                            rules.StringLiteral,
                            shape248)),
                    shape249);
            var fragment57 = Custom(
                    Token(","),
                    Required(
                        OneOrMoreCommaList(
                            fragment55),
                        missing65),
                    shape250);
            var fragment58 = Custom(
                    Token("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape259);
            var fragment59 = Custom(
                    rules.StringLiteral,
                    RequiredToken("roles"),
                    shape265);
            var fragment60 = Custom(
                    Token("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape248);
            var fragment61 = Custom(
                    Token("if_later_than"),
                    rules.StringLiteral,
                    shape248);
            var fragment62 = Custom(
                    Token("with"),
                    RequiredToken("("),
                    RequiredToken("scope"),
                    RequiredToken("="),
                    RequiredToken("cluster", "workloadgroup"),
                    RequiredToken(")"),
                    shape269);
            var fragment63 = Custom(
                    Token("("),
                    ZeroOrMoreCommaList(
                        Custom(
                            If(Not(Token(")")), rules.DatabaseNameReference),
                            shape77),
                        fnMissingElement: rules.MissingNameReference
                        ),
                    RequiredToken(")"),
                    shape274);
            var fragment64 = Custom(
                    Token("as"),
                    RequiredToken("json"));
            var fragment65 = Custom(
                    Token("corrupted"),
                    RequiredToken("datetime"));

            var AddClusterRole = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole2 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("alldatabasesadmins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole3 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("alldatabasesmonitors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole4 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("alldatabasesviewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterBlockedPrincipals = Command("AddClusterBlockedPrincipals", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("blockedprincipals"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment37),
                    Optional(
                        fragment38),
                    Optional(
                        Custom(
                            Token("period"),
                            Required(rules.Value, rules.MissingValue),
                            new [] {CD(), CD("Period", CompletionHint.Literal)})),
                    Optional(
                        Custom(
                            Token("reason"),
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            new [] {CD(), CD("Reason", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD(), CD("Principal", CompletionHint.Literal), CD(isOptional: true), CD(isOptional: true), CD(isOptional: true), CD(isOptional: true)}));

            var AddClusterRole5 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("databasecreators"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole6 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("monitors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole7 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("ops"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole8 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("users"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddClusterRole9 = Command("AddClusterRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var AddDatabaseRole = Command("AddDatabaseRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors", "monitors", "unrestrictedviewers", "users", "viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var AddExternalTableAdmins = Command("AddExternalTableAdmins", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("add", CompletionKind.CommandPrefix),
                        Token("external"),
                        RequiredToken("table"),
                        Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                        RequiredToken("admins"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape5),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(Token("skip-results")),
                        Optional(
                            Custom(
                                rules.StringLiteral,
                                shape6))}
                    ,
                    shape213));

            var AddFollowerDatabaseAuthorizedPrincipals = Command("AddFollowerDatabaseAuthorizedPrincipals", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("add", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        Optional(
                            fragment22),
                        RequiredToken("admins", "monitors", "unrestrictedviewers", "users", "viewers"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape5),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            Custom(
                                rules.StringLiteral,
                                shape6))}
                    ,
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD("operationRole"), CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var AddFunctionRole = Command("AddFunctionRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape217));

            var AddMaterializedViewAdmins = Command("AddMaterializedViewAdmins", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape5),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape6)),
                    shape220));

            var AddTableRole = Command("AddTableRole", 
                Custom(
                    Token("add", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape224));

            var AlterMergeExtentTagsFromQuery = Command("AlterMergeExtentTagsFromQuery", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter-merge", CompletionKind.CommandPrefix),
                        Token("async"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("extent"),
                        RequiredToken("tags"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape51),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment5),
                        Required(
                            fragment6,
                            missing1)}
                    ,
                    shape52));

            var AlterMergeClusterPolicyCallout = Command("AlterMergeClusterPolicyCallout", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterMergeClusterPolicyCapacity = Command("AlterMergeClusterPolicyCapacity", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("capacity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterMergeClusterPolicyDiagnostics = Command("AlterMergeClusterPolicyDiagnostics", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape53));

            var AlterMergeClusterPolicyIngestionBatching = Command("AlterMergeClusterPolicyIngestionBatching", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape54));

            var AlterMergeClusterPolicyManagedIdentity = Command("AlterMergeClusterPolicyManagedIdentity", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape55));

            var AlterMergeClusterPolicyMultiDatabaseAdmins = Command("AlterMergeClusterPolicyMultiDatabaseAdmins", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("multidatabaseadmins"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterMergeClusterPolicyQueryWeakConsistency = Command("AlterMergeClusterPolicyQueryWeakConsistency", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("query_weak_consistency"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterMergeClusterPolicyRequestClassification = Command("AlterMergeClusterPolicyRequestClassification", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterMergeClusterPolicyRowStore = Command("AlterMergeClusterPolicyRowStore", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape57));

            var AlterMergeClusterPolicySharding = Command("AlterMergeClusterPolicySharding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape10));

            var AlterMergeClusterPolicyStreamingIngestion = Command("AlterMergeClusterPolicyStreamingIngestion", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("policy"),
                    RequiredToken("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape10));

            var AlterMergeColumnPolicyEncoding = Command("AlterMergeColumnPolicyEncoding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.TableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape63));

            var AlterMergeDatabaseIngestionMapping = Command("AlterMergeDatabaseIngestionMapping", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape65));

            var AlterMergeDatabasePolicyDiagnostics = Command("AlterMergeDatabasePolicyDiagnostics", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape67));

            var AlterMergeDatabasePolicyEncoding = Command("AlterMergeDatabasePolicyEncoding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape68));

            var AlterMergeDatabasePolicyIngestionBatching = Command("AlterMergeDatabasePolicyIngestionBatching", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape69));

            var AlterMergeDatabasePolicyManagedIdentity = Command("AlterMergeDatabasePolicyManagedIdentity", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("managed_identity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape70));

            var AlterMergeDatabasePolicyMerge = Command("AlterMergeDatabasePolicyMerge", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape71));

            var AlterMergeDatabasePolicyMirroring = Command("AlterMergeDatabasePolicyMirroring", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter-merge", CompletionKind.CommandPrefix),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Token("policy"),
                        Token("mirroring"),
                        Token("dataformat"),
                        RequiredToken("="),
                        RequiredToken("parquet"),
                        Optional(
                            fragment3),
                        Optional(
                            fragment4)}
                    ,
                    shape72));

            var AlterMergeDatabasePolicyMirroringWithJson = Command("AlterMergeDatabasePolicyMirroringWithJson", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("mirroring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape22));

            var AlterMergeDatabasePolicyRetention = Command("AlterMergeDatabasePolicyRetention", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(
                        First(
                            fragment1,
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape28)),
                        missing4),
                    shape66));

            var AlterMergeDatabasePolicySharding = Command("AlterMergeDatabasePolicySharding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape73));

            var AlterMergeDatabasePolicyShardsGrouping = Command("AlterMergeDatabasePolicyShardsGrouping", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape75));

            var AlterMergeDatabasePolicyStreamingIngestion = Command("AlterMergeDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("StreamingIngestionPolicy", CompletionHint.Literal)}));

            var AlterMergeDatabaseTableMirroringPolicyTemplates = Command("AlterMergeDatabaseTableMirroringPolicyTemplates", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("table_mirroring_templates"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape22));

            var AlterMergeEntityGroup = Command("AlterMergeEntityGroup", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            First(
                                fragment10,
                                fragment11)),
                        missing5),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.EntityGroup), CD(), CD(), CD()}));

            var AlterMergeMaterializedViewPolicyMerge = Command("AlterMergeMaterializedViewPolicyMerge", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("MergePolicy", CompletionHint.Literal)}));

            var AlterMergeMaterializedViewPolicyPartitioning = Command("AlterMergeMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape133));

            var AlterMergeMaterializedViewPolicyRetention = Command("AlterMergeMaterializedViewPolicyRetention", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("retention"),
                    Required(
                        First(
                            fragment1,
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape28)),
                        missing4),
                    shape132));

            var AlterMergeTablePolicyEncoding = Command("AlterMergeTablePolicyEncoding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape136));

            var AlterMergeTablePolicyIngestionBatching = Command("AlterMergeTablePolicyIngestionBatching", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape138));

            var AlterMergeTablePolicyMerge = Command("AlterMergeTablePolicyMerge", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape139));

            var AlterMergeTablePolicyMirroring = Command("AlterMergeTablePolicyMirroring", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter-merge", CompletionKind.CommandPrefix),
                        Token("table"),
                        rules.DatabaseTableNameReference,
                        Token("policy"),
                        Token("mirroring"),
                        Optional(
                            fragment27),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("parquet"),
                        Optional(
                            fragment3),
                        Optional(
                            fragment4)}
                    ,
                    shape142));

            var AlterMergeTablePolicyPartitioning = Command("AlterMergeTablePolicyPartitioning", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape143));

            var AlterMergeTablePolicyRetention = Command("AlterMergeTablePolicyRetention", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(
                        First(
                            fragment1,
                            fragment2,
                            Custom(
                                rules.StringLiteral,
                                shape28)),
                        missing4),
                    shape135));

            var AlterMergeTablePolicyRowOrder = Command("AlterMergeTablePolicyRowOrder", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("roworder"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment28),
                        missing10),
                    RequiredToken(")"),
                    shape145));

            var AlterMergeTablePolicySharding = Command("AlterMergeTablePolicySharding", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape146));

            var AlterMergeTablePolicyStreamingIngestion = Command("AlterMergeTablePolicyStreamingIngestion", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("StreamingIngestionPolicy", CompletionHint.Literal)}));

            var AlterMergeTablePolicyUpdate = Command("AlterMergeTablePolicyUpdate", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("policy"),
                    RequiredToken("update"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape148));

            var AlterMergeTable = Command("AlterMergeTable", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    fragment29,
                    Optional(
                        fragment30),
                    shape155));

            var AlterMergeTableColumnDocStrings = Command("AlterMergeTableColumnDocStrings", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("column-docstrings"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment31),
                        missing14),
                    RequiredToken(")"),
                    shape158));

            var AlterMergeExtentTagsFromQuery2 = Command("AlterMergeExtentTagsFromQuery", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter-merge", CompletionKind.CommandPrefix),
                        Token("table"),
                        rules.TableNameReference,
                        Token("extent"),
                        RequiredToken("tags"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape51),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment5),
                        Required(
                            fragment6,
                            missing1)}
                    ,
                    shape159));

            var AlterMergeTableIngestionMapping = Command("AlterMergeTableIngestionMapping", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    RequiredToken("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape160));

            var AlterMergeTablePolicyMirroringWithJson = Command("AlterMergeTablePolicyMirroringWithJson", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("mirroring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape162));

            var AlterMergeWorkloadGroup = Command("AlterMergeWorkloadGroup", 
                Custom(
                    Token("alter-merge", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape179));

            var AlterClusterStorageKeys = Command("AlterClusterStorageKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("async"),
                    Token("cluster"),
                    RequiredToken("storage"),
                    RequiredToken("keys"),
                    Optional(
                        fragment7),
                    RequiredToken("decryption-certificate-thumbprint"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(isOptional: true), CD(), CD("thumbprint", CompletionHint.Literal)}));

            var AlterDatabaseStorageKeys = Command("AlterDatabaseStorageKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("async"),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("storage"),
                    RequiredToken("keys"),
                    Optional(
                        fragment7),
                    RequiredToken("decryption-certificate-thumbprint"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(), CD("thumbprint", CompletionHint.Literal)}));

            var AlterExtentTagsFromQuery = Command("AlterExtentTagsFromQuery", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("async"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("extent"),
                        RequiredToken("tags"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape51),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment5),
                        Required(
                            fragment6,
                            missing1)}
                    ,
                    shape52));

            var AlterCache = Command("AlterCache", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cache"),
                    RequiredToken("on"),
                    Required(
                        First(
                            Token("*"),
                            Custom(
                                rules.BracketedStringLiteral,
                                CD("NodeList", CompletionHint.Literal))),
                        missing15),
                    Required(rules.BracketedStringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("Action", CompletionHint.Literal)}));

            var AlterClusterPolicyCaching = Command("AlterClusterPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment8,
                            fragment9),
                        missing16)));

            var AlterClusterPolicyCallout = Command("AlterClusterPolicyCallout", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterClusterPolicyCapacity = Command("AlterClusterPolicyCapacity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("capacity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterClusterPolicyDiagnostics = Command("AlterClusterPolicyDiagnostics", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape53));

            var AlterClusterPolicyIngestionBatching = Command("AlterClusterPolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape54));

            var AlterClusterPolicyManagedIdentity = Command("AlterClusterPolicyManagedIdentity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape55));

            var AlterClusterPolicyMultiDatabaseAdmins = Command("AlterClusterPolicyMultiDatabaseAdmins", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("multidatabaseadmins"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterClusterPolicyQueryWeakConsistency = Command("AlterClusterPolicyQueryWeakConsistency", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("query_weak_consistency"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape8));

            var AlterClusterPolicyRequestClassification = Command("AlterClusterPolicyRequestClassification", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD(), CD("Policy", CompletionHint.Literal), CD(), CD("Query", CompletionHint.Tabular)}));

            var AlterClusterPolicyRowStore = Command("AlterClusterPolicyRowStore", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape57));

            var AlterClusterPolicySandbox = Command("AlterClusterPolicySandbox", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sandbox"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("SandboxPolicy", CompletionHint.Literal)}));

            var AlterClusterPolicySharding = Command("AlterClusterPolicySharding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape10));

            var AlterClusterPolicyStreamingIngestion = Command("AlterClusterPolicyStreamingIngestion", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    RequiredToken("streamingingestion"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("StreamingIngestionPolicy", CompletionHint.Literal)}));

            var AlterClusterStorageKeys2 = Command("AlterClusterStorageKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("storage"),
                    RequiredToken("keys"),
                    Optional(
                        fragment7),
                    RequiredToken("decryption-certificate-thumbprint"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD(isOptional: true), CD(), CD("thumbprint", CompletionHint.Literal)}));

            var AlterColumnsPolicyEncodingByQuery = Command("AlterColumnsPolicyEncodingByQuery", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("columns"),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD(), CD("EncodingPolicy", CompletionHint.Literal), CD(), CD("QueryOrCommand", CompletionHint.Tabular)}));

            var AlterColumnPolicyCaching = Command("AlterColumnPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment8,
                            fragment9),
                        missing16),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD()}));

            var AlterColumnPolicyEncodingType = Command("AlterColumnPolicyEncodingType", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Token("type"),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD(), CD(), CD("EncodingPolicyType", CompletionHint.Literal)}));

            var AlterColumnPolicyEncoding = Command("AlterColumnPolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    Token("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape63));

            var AlterColumnType = Command("AlterColumnType", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.DatabaseTableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("type"),
                    RequiredToken("="),
                    Required(rules.Type, rules.MissingType),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD(), CD("ColumnType")}));

            var AlterDatabaseIngestionMapping = Command("AlterDatabaseIngestionMapping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape65));

            var AlterDatabasePersistMetadata = Command("AlterDatabasePersistMetadata", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("persist"),
                    RequiredToken("metadata"),
                    Required(
                        First(
                            fragment32,
                            Custom(
                                rules.StringLiteral,
                                shape168)),
                        missing17),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal)}));

            var AlterDatabasePolicyCaching = Command("AlterDatabasePolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment8,
                            fragment9),
                        missing16),
                    shape66));

            var AlterDatabasePolicyDiagnostics = Command("AlterDatabasePolicyDiagnostics", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("diagnostics"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape67));

            var AlterDatabasePolicyEncoding = Command("AlterDatabasePolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape68));

            var AlterDatabasePolicyExtentTagsRetention = Command("AlterDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("ExtentTagsRetentionPolicy", CompletionHint.Literal)}));

            var AlterDatabasePolicyIngestionBatching = Command("AlterDatabasePolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape69));

            var AlterDatabasePolicyManagedIdentity = Command("AlterDatabasePolicyManagedIdentity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("managed_identity"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape70));

            var AlterDatabasePolicyMerge = Command("AlterDatabasePolicyMerge", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape71));

            var AlterDatabasePolicyMirroring = Command("AlterDatabasePolicyMirroring", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Token("policy"),
                        Token("mirroring"),
                        Token("dataformat"),
                        RequiredToken("="),
                        RequiredToken("parquet"),
                        Optional(
                            fragment3),
                        Optional(
                            fragment4)}
                    ,
                    shape72));

            var AlterDatabasePolicyMirroringWithJson = Command("AlterDatabasePolicyMirroringWithJson", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("mirroring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape22));

            var AlterDatabasePolicyRetention = Command("AlterDatabasePolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterDatabasePolicySharding = Command("AlterDatabasePolicySharding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape73));

            var AlterDatabasePolicyShardsGrouping = Command("AlterDatabasePolicyShardsGrouping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape75));

            var AlterDatabasePolicyStreamingIngestion = Command("AlterDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(
                        First(
                            Custom(
                                Token("disable"),
                                shape76),
                            Custom(
                                Token("enable"),
                                shape76),
                            Custom(
                                rules.StringLiteral,
                                shape41)),
                        missing18),
                    shape66));

            var AlterDatabaseTableMirroringPolicyTemplates = Command("AlterDatabaseTableMirroringPolicyTemplates", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    RequiredToken("table_mirroring_templates"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape22));

            var AlterDatabasePrettyName = Command("AlterDatabasePrettyName", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("prettyname"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("DatabasePrettyName", CompletionHint.Literal)}));

            var AlterDatabaseStorageKeys2 = Command("AlterDatabaseStorageKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("storage"),
                    RequiredToken("keys"),
                    Optional(
                        fragment7),
                    RequiredToken("decryption-certificate-thumbprint"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(), CD("thumbprint", CompletionHint.Literal)}));

            var AlterEntityGroup = Command("AlterEntityGroup", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        Custom(
                            OneOrMoreCommaList(
                                First(
                                    fragment10,
                                    fragment11)),
                            RequiredToken(")")),
                        missing19),
                    new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.EntityGroup), CD(), CD()}));

            var AlterExtentContainersAdd = Command("AlterExtentContainersAdd", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    rules.DatabaseNameReference,
                    Token("add"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        Custom(
                            rules.Value,
                            Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                            new [] {CD("hardDeletePeriod", CompletionHint.Literal), CD("containerId", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD("container", CompletionHint.Literal), CD(CompletionHint.Literal, isOptional: true)}));

            var AlterExtentContainersDrop = Command("AlterExtentContainersDrop", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    rules.DatabaseNameReference,
                    Token("drop"),
                    Optional(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape82)),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var AlterExtentContainersRecycle = Command("AlterExtentContainersRecycle", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    rules.DatabaseNameReference,
                    Token("recycle"),
                    Required(
                        First(
                            Custom(
                                Token("older"),
                                Required(
                                    First(
                                        rules.Value,
                                        rules.Value),
                                    rules.MissingValue),
                                RequiredToken("hours"),
                                new [] {CD(), CD("hours", CompletionHint.Literal), CD()}),
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape82)),
                        missing20),
                    shape266));

            var AlterExtentContainersSet = Command("AlterExtentContainersSet", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("set"),
                    RequiredToken("state"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    RequiredToken("to"),
                    RequiredToken("readonly", "readwrite"),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD("container", CompletionHint.Literal), CD(), CD()}));

            var AlterStorageExternalTable = Command("AlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("adl").Hide(),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var AlterStorageExternalTable2 = Command("AlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("blob").Hide(),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var AlterStorageExternalTable3 = Command("AlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("delta"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape173));

            var AlterSqlExternalTable = Command("AlterSqlExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("sql"),
                        Optional(
                            fragment34),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape175));

            var AlterStorageExternalTable4 = Command("AlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("storage"),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var AlterExternalTableDocString = Command("AlterExternalTableDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.ExternalTable), CD(), CD("docStringValue", CompletionHint.Literal)}));

            var AlterExternalTableFolder = Command("AlterExternalTableFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    RequiredToken("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.ExternalTable), CD(), CD("folderValue", CompletionHint.Literal)}));

            var AlterStorageExternalTable5 = Command("AlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("delta"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape176));

            var AlterExternalTableMapping = Command("AlterExternalTableMapping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape185));

            var AlterFabricServiceAssignmentsCommand = Command("AlterFabricServiceAssignmentsCommand", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("fabric"),
                    RequiredToken("service"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(
                        First(
                            Custom(
                                Token("assignments"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                new [] {CD(), CD("serviceToNode", CompletionHint.Literal)}),
                            Custom(
                                Token("assignment"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                RequiredToken("to"),
                                Required(rules.StringLiteral, rules.MissingStringLiteral),
                                new [] {CD(), CD("serviceId", CompletionHint.Literal), CD(), CD("nodeId", CompletionHint.Literal)})),
                        missing27),
                    shape215));

            var AlterFollowerClusterConfiguration = Command("AlterFollowerClusterConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("cluster"),
                    RequiredToken("configuration"),
                    RequiredToken("from"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(
                        First(
                            Custom(
                                Token("database-name-prefix"),
                                RequiredToken("="),
                                Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                                new [] {CD(), CD(), CD("databaseNamePrefix", CompletionHint.None)}),
                            Custom(
                                Token("default-caching-policies-modification-kind"),
                                RequiredToken("="),
                                RequiredToken("none", "replace", "union"),
                                shape106),
                            Custom(
                                Token("default-principals-modification-kind"),
                                RequiredToken("="),
                                RequiredToken("none", "replace", "union"),
                                shape106),
                            Custom(
                                Token("follow-authorized-principals"),
                                RequiredToken("="),
                                Required(rules.Value, rules.MissingValue),
                                new [] {CD(), CD(), CD("followAuthorizedPrincipals", CompletionHint.Literal)})),
                        missing28),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal), CD()}));

            var AlterFollowerDatabaseConfiguration = Command("AlterFollowerDatabaseConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Optional(
                        fragment21),
                    Token("caching-policies-modification-kind"),
                    RequiredToken("="),
                    RequiredToken("none", "replace", "union"),
                    shape124));

            var AlterFollowerDatabaseConfiguration2 = Command("AlterFollowerDatabaseConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Optional(
                        fragment21),
                    Token("database-name-override"),
                    RequiredToken("="),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD(), CD("databaseNameOverride", CompletionHint.None)}));

            var AlterFollowerDatabaseChildEntities = Command("AlterFollowerDatabaseChildEntities", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Optional(
                            fragment21),
                        Token("external"),
                        RequiredToken("tables"),
                        RequiredToken("exclude", "include"),
                        RequiredToken("add", "drop"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.WildcardedNameDeclaration,
                                    CD("ename", CompletionHint.None)),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD(), CD("entityListKind"), CD("operationName"), CD(), CD(CompletionHint.None), CD()}));

            var AlterFollowerTablesPolicyCaching = Command("AlterFollowerTablesPolicyCaching", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        Optional(
                            fragment22),
                        RequiredToken("materialized-views"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.NameDeclaration,
                                    shape125),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")"),
                        RequiredToken("policy"),
                        RequiredToken("caching"),
                        Required(
                            First(
                                fragment23,
                                fragment24),
                            missing30),
                        Optional(
                            fragment25)}
                    ,
                    shape126));

            var AlterFollowerDatabaseChildEntities2 = Command("AlterFollowerDatabaseChildEntities", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Optional(
                            fragment21),
                        Token("materialized-views"),
                        RequiredToken("exclude"),
                        RequiredToken("add", "drop"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.WildcardedNameDeclaration,
                                    CD("ename", CompletionHint.None)),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")")}
                    ,
                    shape111));

            var AlterFollowerDatabaseChildEntities3 = Command("AlterFollowerDatabaseChildEntities", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Optional(
                            fragment21),
                        Token("materialized-views"),
                        RequiredToken("include"),
                        RequiredToken("add", "drop"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.WildcardedNameDeclaration,
                                    CD("ename", CompletionHint.None)),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")")}
                    ,
                    shape111));

            var AlterFollowerTablesPolicyCaching2 = Command("AlterFollowerTablesPolicyCaching", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        Optional(
                            fragment22),
                        RequiredToken("materialized-view"),
                        Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                        RequiredToken("policy"),
                        RequiredToken("caching"),
                        Required(
                            First(
                                fragment23,
                                fragment24),
                            missing30),
                        Optional(
                            fragment25)}
                    ,
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD("name", CompletionHint.MaterializedView), CD(), CD(), CD(), CD("hotWindows", isOptional: true)}));

            var AlterFollowerDatabaseConfiguration3 = Command("AlterFollowerDatabaseConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Optional(
                        fragment21),
                    Token("metadata"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD("serializedDatabaseMetadataOverride", CompletionHint.Literal)}));

            var AlterFollowerDatabaseAuthorizedPrincipals = Command("AlterFollowerDatabaseAuthorizedPrincipals", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Optional(
                        fragment21),
                    Token("policy"),
                    RequiredToken("caching"),
                    Required(
                        First(
                            fragment23,
                            fragment24),
                        missing30),
                    Optional(
                        fragment25),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD(), CD(), CD("hotWindows", isOptional: true)}));

            var AlterFollowerDatabaseConfiguration4 = Command("AlterFollowerDatabaseConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Optional(
                        fragment21),
                    Token("prefetch-extents"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD(), CD("prefetchExtents", CompletionHint.Literal)}));

            var AlterFollowerDatabaseConfiguration5 = Command("AlterFollowerDatabaseConfiguration", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Optional(
                        fragment21),
                    Token("principals-modification-kind"),
                    RequiredToken("="),
                    RequiredToken("none", "replace", "union"),
                    shape124));

            var AlterFollowerTablesPolicyCaching3 = Command("AlterFollowerTablesPolicyCaching", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        Optional(
                            fragment22),
                        RequiredToken("tables"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.NameDeclaration,
                                    shape125),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")"),
                        RequiredToken("policy"),
                        RequiredToken("caching"),
                        Required(
                            First(
                                fragment23,
                                fragment24),
                            missing30),
                        Optional(
                            fragment25)}
                    ,
                    shape126));

            var AlterFollowerDatabaseChildEntities4 = Command("AlterFollowerDatabaseChildEntities", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Optional(
                            fragment21),
                        Token("tables"),
                        RequiredToken("exclude"),
                        RequiredToken("add", "drop"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.WildcardedNameDeclaration,
                                    CD("ename", CompletionHint.None)),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")")}
                    ,
                    shape111));

            var AlterFollowerDatabaseChildEntities5 = Command("AlterFollowerDatabaseChildEntities", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        Token("database"),
                        rules.DatabaseNameReference,
                        Optional(
                            fragment21),
                        Token("tables"),
                        RequiredToken("include"),
                        RequiredToken("add", "drop"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.WildcardedNameDeclaration,
                                    CD("ename", CompletionHint.None)),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")")}
                    ,
                    shape111));

            var AlterFollowerTablesPolicyCaching4 = Command("AlterFollowerTablesPolicyCaching", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        Optional(
                            fragment22),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("policy"),
                        RequiredToken("caching"),
                        Required(
                            First(
                                fragment23,
                                fragment24),
                            missing30),
                        Optional(
                            fragment25)}
                    ,
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(isOptional: true), CD(), CD("name", CompletionHint.Table), CD(), CD(), CD(), CD("hotWindows", isOptional: true)}));

            var AlterFunction = Command("AlterFunction", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    RequiredToken("with"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment0),
                        missing3),
                    RequiredToken(")"),
                    Required(If(Not(Token("with")), rules.DatabaseFunctionNameReference), rules.MissingNameReference),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration),
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.None), CD(), CD("FunctionName", CompletionHint.Function), CD()}));

            var AlterFunctionDocString = Command("AlterFunctionDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    If(Not(Token("with")), rules.DatabaseFunctionNameReference),
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(CompletionHint.Function), CD(), CD("Documentation", CompletionHint.Literal)}));

            var AlterFunctionFolder = Command("AlterFunctionFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    If(Not(Token("with")), rules.DatabaseFunctionNameReference),
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD(), CD("Folder", CompletionHint.Literal)}));

            var AlterFunction2 = Command("AlterFunction", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(If(Not(Token("with")), rules.DatabaseFunctionNameReference), rules.MissingNameReference),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration),
                    shape218));

            var AlterMaterializedViewOverMaterializedView = Command("AlterMaterializedViewOverMaterializedView", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("materialized-view"),
                        Token("with"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment26),
                            missing32),
                        RequiredToken(")"),
                        Required(If(Not(Token("with")), rules.MaterializedViewNameReference), rules.MissingNameReference),
                        RequiredToken("on"),
                        RequiredToken("materialized-view"),
                        Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                        Required(rules.FunctionBody, rules.MissingFunctionBody)}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.MaterializedView), CD()}));

            var AlterMaterializedView = Command("AlterMaterializedView", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("materialized-view"),
                        Token("with"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment26),
                            missing32),
                        RequiredToken(")"),
                        Required(If(Not(Token("with")), rules.MaterializedViewNameReference), rules.MissingNameReference),
                        RequiredToken("on"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        Required(rules.FunctionBody, rules.MissingFunctionBody)}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var AlterMaterializedViewAutoUpdateSchema = Command("AlterMaterializedViewAutoUpdateSchema", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("autoUpdateSchema"),
                    RequiredToken("false", "true"),
                    shape196));

            var AlterMaterializedViewDocString = Command("AlterMaterializedViewDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("Documentation", CompletionHint.Literal)}));

            var AlterMaterializedViewFolder = Command("AlterMaterializedViewFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("Folder", CompletionHint.Literal)}));

            var AlterMaterializedViewLookback = Command("AlterMaterializedViewLookback", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("lookback"),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("Lookback", CompletionHint.Literal)}));

            var AlterMaterializedViewOverMaterializedView2 = Command("AlterMaterializedViewOverMaterializedView", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("on"),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.MaterializedView), CD()}));

            var AlterMaterializedView2 = Command("AlterMaterializedView", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var AlterMaterializedViewPolicyCaching = Command("AlterMaterializedViewPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment8,
                            fragment9),
                        missing16),
                    shape132));

            var AlterMaterializedViewPolicyPartitioning = Command("AlterMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape133));

            var AlterMaterializedViewPolicyRetention = Command("AlterMaterializedViewPolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterMaterializedViewPolicyRowLevelSecurity = Command("AlterMaterializedViewPolicyRowLevelSecurity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(If(Not(Token("with")), rules.MaterializedViewNameReference), rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("row_level_security"),
                    RequiredToken("disable", "enable"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(), CD("Query", CompletionHint.Literal)}));

            var AlterPoliciesOfRetention = Command("AlterPoliciesOfRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("policies"),
                    RequiredToken("of"),
                    RequiredToken("retention"),
                    Optional(Token("internal")),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD(isOptional: true), CD("policies", CompletionHint.Literal)}));

            var AlterTablesPolicyCaching = Command("AlterTablesPolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment8,
                            fragment9),
                        missing16),
                    Optional(
                        fragment25),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD(), CD(isOptional: true)}));

            var AlterTablesPolicyIngestionBatching = Command("AlterTablesPolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD("IngestionBatchingPolicy", CompletionHint.Literal)}));

            var AlterTablesPolicyIngestionTime = Command("AlterTablesPolicyIngestionTime", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("ingestiontime"),
                    RequiredToken("true"),
                    shape134));

            var AlterTablesPolicyMerge = Command("AlterTablesPolicyMerge", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD("policy", CompletionHint.Literal)}));

            var AlterTablesPolicyRestrictedViewAccess = Command("AlterTablesPolicyRestrictedViewAccess", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("restricted_view_access"),
                    RequiredToken("false", "true"),
                    shape134));

            var AlterTablesPolicyRetention = Command("AlterTablesPolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterTablesPolicyRowOrder = Command("AlterTablesPolicyRowOrder", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("tables"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.TableNameReference,
                                    shape29),
                                fnMissingElement: rules.MissingNameReference),
                            missing33),
                        RequiredToken(")"),
                        RequiredToken("policy"),
                        RequiredToken("roworder"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.NameDeclaration,
                                    RequiredToken("asc", "desc"),
                                    new [] {CD("ColumnName", CompletionHint.None), CD()})),
                            missing34),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(), CD(), CD(CompletionHint.None), CD()}));

            var AlterTableColumnStatisticsMethod = Command("AlterTableColumnStatisticsMethod", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("column"),
                    RequiredToken("statistics"),
                    RequiredToken("method"),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(), CD("newMethod", CompletionHint.Literal)}));

            var AlterTablePolicyAutoDelete = Command("AlterTablePolicyAutoDelete", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("auto_delete"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("AutoDeletePolicy", CompletionHint.Literal)}));

            var AlterTablePolicyCaching = Command("AlterTablePolicyCaching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("caching"),
                    Required(
                        First(
                            fragment8,
                            fragment9),
                        missing16),
                    shape135));

            var AlterTablePolicyEncoding = Command("AlterTablePolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape136));

            var AlterTablePolicyExtentTagsRetention = Command("AlterTablePolicyExtentTagsRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("ExtentTagsRetentionPolicy", CompletionHint.Literal)}));

            var AlterTablePolicyIngestionBatching = Command("AlterTablePolicyIngestionBatching", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape138));

            var AlterTablePolicyMerge = Command("AlterTablePolicyMerge", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("merge"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape139));

            var AlterTablePolicyMirroring = Command("AlterTablePolicyMirroring", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("table"),
                        rules.DatabaseTableNameReference,
                        Token("policy"),
                        Token("mirroring"),
                        Optional(
                            fragment27),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("parquet"),
                        Optional(
                            fragment3),
                        Optional(
                            fragment4)}
                    ,
                    shape142));

            var AlterTablePolicyPartitioning = Command("AlterTablePolicyPartitioning", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape143));

            var AlterTablePolicyRestrictedViewAccess = Command("AlterTablePolicyRestrictedViewAccess", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("restricted_view_access"),
                    RequiredToken("false", "true"),
                    shape135));

            var AlterTablePolicyRetention = Command("AlterTablePolicyRetention", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("retention"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD("RetentionPolicy", CompletionHint.Literal)}));

            var AlterTablePolicyRowOrder = Command("AlterTablePolicyRowOrder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("roworder"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment28),
                        missing10),
                    RequiredToken(")"),
                    shape145));

            var AlterTablePolicySharding = Command("AlterTablePolicySharding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("sharding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape146));

            var AlterTablePolicyStreamingIngestion = Command("AlterTablePolicyStreamingIngestion", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    Required(
                        First(
                            Custom(
                                Token("disable"),
                                shape76),
                            Custom(
                                Token("enable"),
                                shape76),
                            Custom(
                                rules.StringLiteral,
                                shape41)),
                        missing18),
                    shape135));

            var AlterTablePolicyUpdate = Command("AlterTablePolicyUpdate", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    RequiredToken("update"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape148));

            var AlterTableRowStoreReferencesDisableBlockedKeys = Command("AlterTableRowStoreReferencesDisableBlockedKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("disable"),
                    Token("blocked"),
                    RequiredToken("keys"),
                    Optional(
                        fragment7),
                    shape149));

            var AlterTableRowStoreReferencesDisableKey = Command("AlterTableRowStoreReferencesDisableKey", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("disable"),
                    Token("key"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape151));

            var AlterTableRowStoreReferencesDisableRowStore = Command("AlterTableRowStoreReferencesDisableRowStore", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("disable"),
                    RequiredToken("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment7),
                    shape153));

            var AlterTableRowStoreReferencesDropBlockedKeys = Command("AlterTableRowStoreReferencesDropBlockedKeys", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("drop"),
                    Token("blocked"),
                    RequiredToken("keys"),
                    Optional(
                        fragment7),
                    shape149));

            var AlterTableRowStoreReferencesDropKey = Command("AlterTableRowStoreReferencesDropKey", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("rowstore_references"),
                    Token("drop"),
                    Token("key"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape151));

            var AlterTableRowStoreReferencesDropRowStore = Command("AlterTableRowStoreReferencesDropRowStore", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("rowstore_references"),
                    RequiredToken("drop"),
                    RequiredToken("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment7),
                    shape153));

            var AlterTable = Command("AlterTable", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    fragment29,
                    Optional(
                        fragment30),
                    shape155));

            var AlterTableColumnDocStrings = Command("AlterTableColumnDocStrings", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("column-docstrings"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            fragment31),
                        missing14),
                    RequiredToken(")"),
                    shape158));

            var AlterTableColumnsPolicyEncoding = Command("AlterTableColumnsPolicyEncoding", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("columns"),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD("EncodingPolicies", CompletionHint.Literal)}));

            var AlterTableColumnStatistics = Command("AlterTableColumnStatistics", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("column"),
                    RequiredToken("statistics"),
                    ZeroOrMoreCommaList(
                        Custom(
                            rules.NameDeclaration,
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            new [] {CD("c2", CompletionHint.None), CD("statisticsValues2", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(CompletionHint.None)}));

            var AlterTableDocString = Command("AlterTableDocString", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("docstring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("Documentation", CompletionHint.Literal)}));

            var AlterExtentTagsFromQuery2 = Command("AlterExtentTagsFromQuery", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("alter", CompletionKind.CommandPrefix),
                        Token("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("extent"),
                        RequiredToken("tags"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape51),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment5),
                        Required(
                            fragment6,
                            missing1)}
                    ,
                    shape159));

            var AlterTableFolder = Command("AlterTableFolder", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("folder"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("Folder", CompletionHint.Literal)}));

            var AlterTableIngestionMapping = Command("AlterTableIngestionMapping", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape160));

            var AlterTablePolicyIngestionTime = Command("AlterTablePolicyIngestionTime", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    RequiredToken("policy"),
                    RequiredToken("ingestiontime"),
                    RequiredToken("true"),
                    shape135));

            var AlterTablePolicyMirroringWithJson = Command("AlterTablePolicyMirroringWithJson", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseNameReference,
                    RequiredToken("policy"),
                    RequiredToken("mirroring"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape162));

            var AlterTablePolicyRowLevelSecurity = Command("AlterTablePolicyRowLevelSecurity", 
                Custom(
                    Token("alter", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("row_level_security"),
                    RequiredToken("disable", "enable"),
                    Optional(
                        fragment5),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(), CD(isOptional: true), CD("Query", CompletionHint.Literal)}));

            var AppendTable = Command("AppendTable", 
                Custom(
                    Token("append", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Required(If(Not(Token("async")), rules.TableNameReference), rules.MissingNameReference),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD("TableName", CompletionHint.Table), CD(isOptional: true), CD(), CD("QueryOrCommand", CompletionHint.Tabular)}));

            var ApplyTableMirroringPolicyTemplateToTables = Command("ApplyTableMirroringPolicyTemplateToTables", 
                Custom(
                    Token("apply", CompletionKind.CommandPrefix),
                    RequiredToken("table_mirroring_template"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.TableNameReference,
                                            shape29),
                                        fnMissingElement: rules.MissingNameReference),
                                    missing33),
                                RequiredToken(")"),
                                new [] {CD(), CD(CompletionHint.Table), CD()}),
                            Custom(
                                fragment6,
                                shape45)),
                        missing37),
                    new [] {CD(), CD(), CD("TemplateName", CompletionHint.None), CD()}));

            var AttachExtentsIntoTableByMetadata = Command("AttachExtentsIntoTableByMetadata", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    RequiredToken("async"),
                    RequiredToken("extents"),
                    ZeroOrMoreList(
                        fragment33),
                    RequiredToken("by"),
                    RequiredToken("metadata"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD("csl")}));

            var AttachDatabaseMetadata = Command("AttachDatabaseMetadata", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("metadata"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment32,
                            Custom(
                                rules.StringLiteral,
                                shape168)),
                        missing17),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Literal)}));

            var AttachDatabase = Command("AttachDatabase", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(If(Not(Token("metadata")), rules.DatabaseNameReference), rules.MissingNameReference),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment32,
                            Custom(
                                rules.StringLiteral,
                                shape168)),
                        missing17),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Literal)}));

            var AttachExtentsIntoTableByMetadata2 = Command("AttachExtentsIntoTableByMetadata", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    RequiredToken("extents"),
                    RequiredToken("by"),
                    RequiredToken("metadata"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD(), CD("csl")}));

            var AttachExtentsIntoTableByContainer = Command("AttachExtentsIntoTableByContainer", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    Token("extents"),
                    Token("into"),
                    Token("table"),
                    rules.TableNameReference,
                    Token("by"),
                    Token("container"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(
                        OneOrMoreList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape286)),
                        missing38),
                    new [] {CD(), CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD("containerUri", CompletionHint.Literal), CD(CompletionHint.Literal)}));

            var AttachExtentsIntoTableByMetadata3 = Command("AttachExtentsIntoTableByMetadata", 
                Custom(
                    Token("attach", CompletionKind.CommandPrefix),
                    RequiredToken("extents"),
                    RequiredToken("into"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    ZeroOrMoreList(
                        fragment33),
                    RequiredToken("by"),
                    RequiredToken("metadata"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD("csl")}));

            var CancelOperation = Command("CancelOperation", 
                Custom(
                    Token("cancel", CompletionKind.CommandPrefix),
                    Token("operation"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("obj", CompletionHint.Literal), CD(isOptional: true)}));

            var CancelQuery = Command("CancelQuery", 
                Custom(
                    Token("cancel", CompletionKind.CommandPrefix),
                    RequiredToken("query"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("ClientRequestId", CompletionHint.Literal)}));

            var CleanDatabaseExtentContainers = Command("CleanDatabaseExtentContainers", 
                Custom(
                    Token("clean", CompletionKind.CommandPrefix),
                    RequiredToken("databases"),
                    Optional(Token("async")),
                    Optional(
                        fragment63),
                    RequiredToken("extentcontainers"),
                    new [] {CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD()}));

            var ClearTableData = Command("ClearTableData", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    RequiredToken("async"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("data"),
                    new [] {CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD()}));

            var ClearRemoteClusterDatabaseSchema = Command("ClearRemoteClusterDatabaseSchema", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("clear", CompletionKind.CommandPrefix),
                        Token("cache"),
                        RequiredToken("remote-schema"),
                        RequiredToken("cluster"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        RequiredToken("."),
                        RequiredToken("database"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("clusterName", CompletionHint.Literal), CD(), CD(), CD(), CD(), CD("databaseName", CompletionHint.Literal), CD()}));

            var ClearClusterCredStoreCache = Command("ClearClusterCredStoreCache", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("cache"),
                    Token("credstore")));

            var ClearExternalArtifactsCache = Command("ClearExternalArtifactsCache", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("cache"),
                    Token("external-artifacts"),
                    Required(
                        Custom(
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.StringLiteral,
                                        CD("ArtifactUri", CompletionHint.Literal)),
                                    fnMissingElement: rules.MissingStringLiteral),
                                missing0),
                            RequiredToken(")"),
                            shape38),
                        missing2)));

            var ClearClusterGroupMembershipCache = Command("ClearClusterGroupMembershipCache", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("cache"),
                    RequiredToken("groupmembership"),
                    Optional(
                        fragment5),
                    shape245));

            var ClearDatabaseCacheQueryResults = Command("ClearDatabaseCacheQueryResults", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cache"),
                    Token("query_results")));

            var ClearDatabaseCacheQueryWeakConsistency = Command("ClearDatabaseCacheQueryWeakConsistency", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cache"),
                    Token("query_weak_consistency")));

            var ClearDatabaseCacheStreamingIngestionSchema = Command("ClearDatabaseCacheStreamingIngestionSchema", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("database"),
                    RequiredToken("cache"),
                    RequiredToken("streamingingestion"),
                    RequiredToken("schema")));

            var ClearMaterializedViewData = Command("ClearMaterializedViewData", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("data"),
                    shape277));

            var ClearMaterializedViewStatistics = Command("ClearMaterializedViewStatistics", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("statistics"),
                    shape279));

            var ClearTableCacheStreamingIngestionSchema = Command("ClearTableCacheStreamingIngestionSchema", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("cache"),
                    RequiredToken("streamingingestion"),
                    RequiredToken("schema"),
                    shape135));

            var ClearTableData2 = Command("ClearTableData", 
                Custom(
                    Token("clear", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("data"),
                    shape225));

            var CreateMergeTables = Command("CreateMergeTables", 
                Custom(
                    Token("create-merge", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            fragment36),
                        missing39),
                    Optional(
                        fragment7),
                    shape189));

            var CreateMergeTable = Command("CreateMergeTable", 
                Custom(
                    Token("create-merge", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        fragment29,
                        missing35),
                    Optional(
                        fragment30),
                    shape190));

            var CreateOrAlterContinuousExport = Command("CreateOrAlterContinuousExport", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("continuous-export"),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        Optional(
                            Custom(
                                Token("over"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.NameDeclaration,
                                            shape170),
                                        fnMissingElement: rules.MissingNameDeclaration),
                                    missing29),
                                RequiredToken(")"),
                                shape19)),
                        RequiredToken("to"),
                        RequiredToken("table"),
                        Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                        Optional(
                            fragment7),
                        RequiredToken("<|"),
                        Required(rules.QueryInput, rules.MissingExpression)}
                    ,
                    new [] {CD(), CD(), CD("ContinuousExportName", CompletionHint.None), CD(isOptional: true), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var CreateOrAlterDatabaseIngestionMapping = Command("CreateOrAlterDatabaseIngestionMapping", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape183));

            var CreateOrAlterEntityGroupCommand = Command("CreateOrAlterEntityGroupCommand", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            First(
                                fragment10,
                                fragment11)),
                        missing5),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.None), CD(), CD(), CD()}));

            var CreateOrAlterStorageExternalTable = Command("CreateOrAlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("adl").Hide(),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var CreateOrAlterStorageExternalTable2 = Command("CreateOrAlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("blob").Hide(),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var CreateOrAlterStorageExternalTable3 = Command("CreateOrAlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        RequiredToken("table"),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("delta"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape173));

            var CreateOrAlterSqlExternalTable = Command("CreateOrAlterSqlExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("sql"),
                        Optional(
                            fragment34),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape175));

            var CreateOrAlterStorageExternalTable4 = Command("CreateOrAlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("storage"),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var CreateOrAlterStorageExternalTable5 = Command("CreateOrAlterStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create-or-alter", CompletionKind.CommandPrefix),
                        Token("external"),
                        RequiredToken("table"),
                        Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("delta"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape176));

            var CreateOrAlterFunction = Command("CreateOrAlterFunction", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("function"),
                    Optional(
                        fragment4),
                    Required(If(Not(Token("with")), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration),
                    new [] {CD(), CD(), CD(isOptional: true), CD("FunctionName", CompletionHint.None), CD()}));

            var CreateOrAlterMaterializedViewOverMaterializedView = Command("CreateOrAlterMaterializedViewOverMaterializedView", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Optional(
                        fragment35),
                    If(Not(Token("with")), rules.MaterializedViewNameReference),
                    Token("on"),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.MaterializedView), CD()}));

            var CreateOrAlterMaterializedView = Command("CreateOrAlterMaterializedView", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Optional(
                        fragment35),
                    Required(If(Not(Token("with")), rules.MaterializedViewNameReference), rules.MissingNameReference),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var CreateOrAlterTableIngestionMapping = Command("CreateOrAlterTableIngestionMapping", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    shape160));

            var CreateOrAleterWorkloadGroup = Command("CreateOrAleterWorkloadGroup", 
                Custom(
                    Token("create-or-alter", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape179));

            var CreateMaterializedViewOverMaterializedView = Command("CreateMaterializedViewOverMaterializedView", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("async"),
                        Optional(Token("ifnotexists")),
                        Token("materialized-view"),
                        Optional(
                            fragment35),
                        If(Not(Token("with")), rules.NameDeclaration),
                        Token("on"),
                        Token("materialized-view"),
                        Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                        Required(rules.FunctionBody, rules.MissingFunctionBody)}
                    ,
                    new [] {CD(), CD(), CD(isOptional: true), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.None), CD(), CD(), CD(CompletionHint.MaterializedView), CD()}));

            var CreateMaterializedView = Command("CreateMaterializedView", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("async"),
                        Optional(Token("ifnotexists")),
                        RequiredToken("materialized-view"),
                        Optional(
                            fragment35),
                        Required(If(Not(Token("with")), rules.NameDeclaration), rules.MissingNameDeclaration),
                        RequiredToken("on"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        Required(rules.FunctionBody, rules.MissingFunctionBody)}
                    ,
                    new [] {CD(), CD(), CD(isOptional: true), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.None), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var CreateBasicAuthUser = Command("CreateBasicAuthUser", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("basicauth"),
                    RequiredToken("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        Custom(
                            Token("password"),
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            new [] {CD(), CD("Password", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD(), CD("UserName", CompletionHint.Literal), CD(isOptional: true)}));

            var CreateDatabaseIngestionMapping = Command("CreateDatabaseIngestionMapping", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.NameDeclaration,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape183));

            var CreateDatabasePersist = Command("CreateDatabasePersist", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.NameDeclaration,
                    Token("persist"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                CD("Container", CompletionHint.Literal)),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(Token("ifnotexists")),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var CreateDatabaseVolatile = Command("CreateDatabaseVolatile", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("volatile"),
                    Optional(Token("ifnotexists")),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(), CD(isOptional: true)}));

            var CreateEntityGroupCommand = Command("CreateEntityGroupCommand", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(Token("ifnotexists")),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            First(
                                Custom(
                                    Token("cluster"),
                                    Token("("),
                                    rules.StringLiteral,
                                    Token(")"),
                                    Token("."),
                                    RequiredToken("database"),
                                    RequiredToken("("),
                                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                                    RequiredToken(")"),
                                    shape80),
                                Custom(
                                    Token("cluster"),
                                    RequiredToken("("),
                                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                                    RequiredToken(")"),
                                    new [] {CD(), CD(), CD("clusterName", CompletionHint.Literal), CD()}),
                                fragment11)),
                        missing5),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("EntityGroupName", CompletionHint.None), CD(isOptional: true), CD(), CD(), CD()}));

            var CreateStorageExternalTable = Command("CreateStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("adl").Hide(),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var CreateStorageExternalTable2 = Command("CreateStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("blob").Hide(),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var CreateStorageExternalTable3 = Command("CreateStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("delta"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape173));

            var CreateSqlExternalTable = Command("CreateSqlExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        OneOrMoreCommaList(
                            fragment12),
                        Token(")"),
                        Token("kind"),
                        RequiredToken("="),
                        RequiredToken("sql"),
                        Optional(
                            fragment34),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape175));

            var CreateStorageExternalTable4 = Command("CreateStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                fragment12),
                            missing12),
                        RequiredToken(")"),
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("storage"),
                        Optional(
                            fragment19),
                        Optional(
                            fragment20),
                        RequiredToken("dataformat"),
                        RequiredToken("="),
                        RequiredToken("apacheavro", "avro", "csv", "json", "multijson", "orc", "parquet", "psv", "raw", "scsv", "sohsv", "sstream", "tsve", "tsv", "txt", "w3clogfile"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape37),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape101));

            var CreateStorageExternalTable5 = Command("CreateStorageExternalTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("create", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.NameDeclaration,
                        RequiredToken("kind"),
                        RequiredToken("="),
                        RequiredToken("delta"),
                        RequiredToken("("),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        RequiredToken(")"),
                        Optional(
                            fragment4)}
                    ,
                    shape176));

            var CreateExternalTableMapping = Command("CreateExternalTableMapping", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape185));

            var CreateFunction = Command("CreateFunction", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("function"),
                    Optional(Token("ifnotexists")),
                    Optional(
                        fragment5),
                    Required(If(Not(And(Token("ifnotexists", "with"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Required(rules.FunctionDeclaration, rules.MissingFunctionDeclaration),
                    new [] {CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD("FunctionName", CompletionHint.None), CD()}));

            var CreateMaterializedViewOverMaterializedView2 = Command("CreateMaterializedViewOverMaterializedView", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("ifnotexists"),
                    Token("materialized-view"),
                    Optional(
                        fragment35),
                    If(Not(Token("with")), rules.NameDeclaration),
                    Token("on"),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.None), CD(), CD(), CD(CompletionHint.MaterializedView), CD()}));

            var CreateMaterializedView2 = Command("CreateMaterializedView", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("ifnotexists"),
                    RequiredToken("materialized-view"),
                    Optional(
                        fragment35),
                    Required(If(Not(Token("with")), rules.NameDeclaration), rules.MissingNameDeclaration),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.None), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var CreateMaterializedViewOverMaterializedView3 = Command("CreateMaterializedViewOverMaterializedView", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Optional(
                        fragment35),
                    If(Not(Token("with")), rules.NameDeclaration),
                    Token("on"),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.None), CD(), CD(), CD(CompletionHint.MaterializedView), CD()}));

            var CreateMaterializedView3 = Command("CreateMaterializedView", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Optional(
                        fragment35),
                    Required(If(Not(Token("with")), rules.NameDeclaration), rules.MissingNameDeclaration),
                    RequiredToken("on"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(rules.FunctionBody, rules.MissingFunctionBody),
                    new [] {CD(), CD(), CD(isOptional: true), CD("MaterializedViewName", CompletionHint.None), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var CreateRequestSupport = Command("CreateRequestSupport", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("request_support"),
                    Optional(
                        fragment7),
                    shape187));

            var CreateRowStore = Command("CreateRowStore", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Optional(
                        fragment7),
                    shape187));

            var CreateTables = Command("CreateTables", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            fragment36),
                        missing39),
                    Optional(
                        fragment7),
                    shape189));

            var CreateTable = Command("CreateTable", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.NameDeclaration,
                    fragment29,
                    Optional(
                        fragment30),
                    shape190));

            var CreateTableBasedOnAnother = Command("CreateTableBasedOnAnother", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.NameDeclaration,
                    Token("based-on"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(Token("ifnotexists")),
                    Optional(
                        fragment30),
                    new [] {CD(), CD(), CD("NewTableName", CompletionHint.None), CD(), CD("TableName", CompletionHint.None), CD(isOptional: true), CD(isOptional: true)}));

            var CreateTableIngestionMapping = Command("CreateTableIngestionMapping", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.None), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal), CD("MappingFormat", CompletionHint.Literal), CD(isOptional: true)}));

            var CreateTempStorage = Command("CreateTempStorage", 
                Custom(
                    Token("create", CompletionKind.CommandPrefix),
                    RequiredToken("tempstorage")));

            var DefineTables = Command("DefineTables", 
                Custom(
                    Token("define", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            fragment36),
                        missing39),
                    Optional(
                        fragment7),
                    shape189));

            var DefineTable = Command("DefineTable", 
                Custom(
                    Token("define", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        fragment29,
                        missing35),
                    Optional(
                        fragment30),
                    shape190));

            var DeleteMaterializedViewRecords = Command("DeleteMaterializedViewRecords", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("async"),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("records"),
                    Optional(
                        fragment7),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(isOptional: true), CD("csl")}));

            var DeleteTableRecords = Command("DeleteTableRecords", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    RequiredToken("async"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("records"),
                    Optional(
                        fragment7),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD("csl")}));

            var DeleteClusterPolicyCaching = Command("DeleteClusterPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("caching")));

            var DeleteClusterPolicyCallout = Command("DeleteClusterPolicyCallout", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout")));

            var DeleteClusterPolicyManagedIdentity = Command("DeleteClusterPolicyManagedIdentity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity")));

            var DeleteClusterPolicyRequestClassification = Command("DeleteClusterPolicyRequestClassification", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification")));

            var DeleteClusterPolicyRowStore = Command("DeleteClusterPolicyRowStore", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore")));

            var DeleteClusterPolicySandbox = Command("DeleteClusterPolicySandbox", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sandbox")));

            var DeleteClusterPolicySharding = Command("DeleteClusterPolicySharding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding")));

            var DeleteClusterPolicyStreamingIngestion = Command("DeleteClusterPolicyStreamingIngestion", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("policy"),
                    RequiredToken("streamingingestion")));

            var DeleteColumnPolicyCaching = Command("DeleteColumnPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("column"),
                    rules.DatabaseTableColumnNameReference,
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    shape191));

            var DeleteColumnPolicyEncoding = Command("DeleteColumnPolicyEncoding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.TableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    shape191));

            var DeleteDatabasePolicyCaching = Command("DeleteDatabasePolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape192));

            var DeleteDatabasePolicyDiagnostics = Command("DeleteDatabasePolicyDiagnostics", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("diagnostics"),
                    shape192));

            var DeleteDatabasePolicyEncoding = Command("DeleteDatabasePolicyEncoding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("encoding"),
                    shape192));

            var DeleteDatabasePolicyExtentTagsRetention = Command("DeleteDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape192));

            var DeleteDatabasePolicyIngestionBatching = Command("DeleteDatabasePolicyIngestionBatching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape192));

            var DeleteDatabasePolicyManagedIdentity = Command("DeleteDatabasePolicyManagedIdentity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("managed_identity"),
                    shape192));

            var DeleteDatabasePolicyMerge = Command("DeleteDatabasePolicyMerge", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("merge"),
                    shape192));

            var DeleteDatabasePolicyMirroring = Command("DeleteDatabasePolicyMirroring", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("mirroring"),
                    shape192));

            var DeleteDatabasePolicyRetention = Command("DeleteDatabasePolicyRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("retention"),
                    shape192));

            var DeleteDatabasePolicySharding = Command("DeleteDatabasePolicySharding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("sharding"),
                    shape192));

            var DeleteDatabasePolicyShardsGrouping = Command("DeleteDatabasePolicyShardsGrouping", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("shards_grouping").Hide(),
                    shape192));

            var DeleteDatabasePolicyStreamingIngestion = Command("DeleteDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    shape192));

            var DropDatabaseTableMirroringPolicyTemplates = Command("DropDatabaseTableMirroringPolicyTemplates", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("table_mirroring_templates"),
                    shape192));

            var DropFollowerTablesPolicyCaching = Command("DropFollowerTablesPolicyCaching", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("delete", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        RequiredToken("materialized-views"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.NameDeclaration,
                                    shape125),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")"),
                        RequiredToken("policy"),
                        RequiredToken("caching")}
                    ,
                    shape194));

            var DropFollowerTablesPolicyCaching2 = Command("DropFollowerTablesPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD("name", CompletionHint.MaterializedView), CD(), CD()}));

            var DropFollowerDatabasePolicyCaching = Command("DropFollowerDatabasePolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD()}));

            var DropFollowerTablesPolicyCaching3 = Command("DropFollowerTablesPolicyCaching", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("delete", CompletionKind.CommandPrefix),
                        Token("follower"),
                        RequiredToken("database"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        RequiredToken("tables"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.NameDeclaration,
                                    shape125),
                                fnMissingElement: rules.MissingNameDeclaration),
                            missing29),
                        RequiredToken(")"),
                        RequiredToken("policy"),
                        RequiredToken("caching")}
                    ,
                    shape194));

            var DropFollowerTablesPolicyCaching4 = Command("DropFollowerTablesPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD(), CD("name", CompletionHint.Table), CD(), CD()}));

            var DeleteMaterializedViewPolicyCaching = Command("DeleteMaterializedViewPolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape196));

            var DeleteMaterializedViewPolicyPartitioning = Command("DeleteMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    shape196));

            var DeleteMaterializedViewPolicyRowLevelSecurity = Command("DeleteMaterializedViewPolicyRowLevelSecurity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape196));

            var DeleteMaterializedViewRecords2 = Command("DeleteMaterializedViewRecords", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("records"),
                    Optional(
                        fragment7),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(isOptional: true), CD("csl")}));

            var DeletePoliciesOfRetention = Command("DeletePoliciesOfRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("policies"),
                    RequiredToken("of"),
                    RequiredToken("retention"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                CD("entity", CompletionHint.Literal)),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD()}));

            var DeleteTablePolicyAutoDelete = Command("DeleteTablePolicyAutoDelete", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("auto_delete"),
                    shape197));

            var DeleteTablePolicyCaching = Command("DeleteTablePolicyCaching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape197));

            var DeleteTablePolicyEncoding = Command("DeleteTablePolicyEncoding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("encoding"),
                    shape197));

            var DeleteTablePolicyExtentTagsRetention = Command("DeleteTablePolicyExtentTagsRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape197));

            var DeleteTablePolicyIngestionBatching = Command("DeleteTablePolicyIngestionBatching", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape197));

            var DeleteTablePolicyMerge = Command("DeleteTablePolicyMerge", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("merge"),
                    shape197));

            var DeleteTablePolicyMirroring = Command("DeleteTablePolicyMirroring", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("mirroring"),
                    shape197));

            var DeleteTablePolicyPartitioning = Command("DeleteTablePolicyPartitioning", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    shape197));

            var DeleteTablePolicyRestrictedViewAccess = Command("DeleteTablePolicyRestrictedViewAccess", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("restricted_view_access"),
                    shape197));

            var DeleteTablePolicyRetention = Command("DeleteTablePolicyRetention", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("retention"),
                    shape197));

            var DeleteTablePolicyRowOrder = Command("DeleteTablePolicyRowOrder", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("roworder"),
                    shape197));

            var DeleteTablePolicySharding = Command("DeleteTablePolicySharding", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("sharding"),
                    shape197));

            var DeleteTablePolicyStreamingIngestion = Command("DeleteTablePolicyStreamingIngestion", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    Token("policy"),
                    Token("streamingingestion"),
                    shape197));

            var DeleteTablePolicyUpdate = Command("DeleteTablePolicyUpdate", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("policy"),
                    RequiredToken("update"),
                    shape197));

            var DeleteTablePolicyIngestionTime = Command("DeleteTablePolicyIngestionTime", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    Token("ingestiontime"),
                    shape197));

            var DeleteTablePolicyRowLevelSecurity = Command("DeleteTablePolicyRowLevelSecurity", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape197));

            var DeleteTableRecords2 = Command("DeleteTableRecords", 
                Custom(
                    Token("delete", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("records"),
                    Optional(
                        fragment7),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD("csl")}));

            var DetachDatabase = Command("DetachDatabase", 
                Custom(
                    Token("detach", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database)}));

            var DropRowStore = Command("DropRowStore", 
                Custom(
                    Token("detach", CompletionKind.CommandPrefix),
                    RequiredToken("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(Token("ifexists")),
                    shape222));

            var DisableContinuousExport = Command("DisableContinuousExport", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("ContinousExportName", CompletionHint.None)}));

            var DisableDatabaseStreamingIngestionMaintenanceMode = Command("DisableDatabaseStreamingIngestionMaintenanceMode", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("streamingingestion_maintenance_mode")));

            var DisableDatabaseMaintenanceMode = Command("DisableDatabaseMaintenanceMode", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(If(Not(Token("streamingingestion_maintenance_mode")), rules.DatabaseNameReference), rules.MissingNameReference),
                    RequiredToken("maintenance_mode"),
                    shape203));

            var EnableDisableMaterializedView = Command("EnableDisableMaterializedView", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape221));

            var DisablePlugin = Command("DisablePlugin", 
                Custom(
                    Token("disable", CompletionKind.CommandPrefix),
                    RequiredToken("plugin"),
                    Required(
                        First(
                            rules.StringLiteral,
                            rules.NameDeclaration),
                        rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("pluginName", CompletionHint.Literal)}));

            var DropPretendExtentsByProperties = Command("DropPretendExtentsByProperties", 
                Custom(
                    Token("drop-pretend", CompletionKind.CommandPrefix),
                    RequiredToken("extents"),
                    Optional(
                        Custom(
                            Token("older"),
                            Required(rules.Value, rules.MissingValue),
                            RequiredToken("days", "hours"),
                            new [] {CD(), CD("Older", CompletionHint.Literal), CD()})),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment39,
                            Custom(
                                If(Not(Token("all")), rules.TableNameReference),
                                shape29)),
                        missing53),
                    Optional(
                        fragment40),
                    Optional(
                        fragment41),
                    new [] {CD(), CD(), CD(isOptional: true), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var DropEmptyExtentContainers = Command("DropEmptyExtentContainers", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("drop", CompletionKind.CommandPrefix),
                        Token("async"),
                        Token("empty"),
                        RequiredToken("extentcontainers"),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        RequiredToken("until"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        Optional(Token("whatif")),
                        Optional(
                            fragment7)}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD("d", CompletionHint.Literal), CD(isOptional: true), CD(isOptional: true)}));

            var DropExtentTagsFromTable = Command("DropExtentTagsFromTable", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("drop", CompletionKind.CommandPrefix),
                        Token("async"),
                        Token("table"),
                        rules.TableNameReference,
                        Token("extent"),
                        Token("tags"),
                        Token("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape51),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment5)}
                    ,
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var DropExtentTagsFromQuery = Command("DropExtentTagsFromQuery", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("async"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("extent"),
                    RequiredToken("tags"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD("csl")}));

            var DropExtentTagsFromQuery2 = Command("DropExtentTagsFromQuery", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("drop", CompletionKind.CommandPrefix),
                        Token("async"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("extent"),
                        RequiredToken("tags"),
                        RequiredToken("with"),
                        RequiredToken("("),
                        ZeroOrMoreCommaList(
                            fragment0),
                        RequiredToken(")"),
                        Required(
                            fragment6,
                            missing1)}
                    ,
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD(), CD(CompletionHint.None), CD(), CD("csl")}));

            var DropBasicAuthUser = Command("DropBasicAuthUser", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("basicauth"),
                    RequiredToken("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("UserName", CompletionHint.Literal)}));

            var DropClusterRole = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole2 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("alldatabasesadmins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole3 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("alldatabasesmonitors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole4 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("alldatabasesviewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterBlockedPrincipals = Command("DropClusterBlockedPrincipals", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("blockedprincipals"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment37),
                    Optional(
                        fragment38),
                    new [] {CD(), CD(), CD(), CD("Principal", CompletionHint.Literal), CD(isOptional: true), CD(isOptional: true)}));

            var DropClusterRole5 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("databasecreators"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole6 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("monitors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole7 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("ops"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole8 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("users"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropClusterRole9 = Command("DropClusterRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape1));

            var DropColumn = Command("DropColumn", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.TableColumnNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column)}));

            var DropContinuousExport = Command("DropContinuousExport", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape226));

            var DropDatabaseRole = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var DropDatabaseIngestionMapping = Command("DropDatabaseIngestionMapping", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal)}));

            var DropDatabaseRole2 = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("ingestors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var DropDatabaseRole3 = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("monitors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var DropDatabasePrettyName = Command("DropDatabasePrettyName", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("prettyname"),
                    shape203));

            var DropDatabaseRole4 = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("unrestrictedviewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var DropDatabaseRole5 = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("users"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var DropDatabaseRole6 = Command("DropDatabaseRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("viewers"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape202));

            var DropEmptyExtentContainers2 = Command("DropEmptyExtentContainers", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("empty"),
                    RequiredToken("extentcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("until"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    Optional(Token("whatif")),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD("d", CompletionHint.Literal), CD(isOptional: true), CD(isOptional: true)}));

            var DropEntityGroup = Command("DropEntityGroup", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    shape270));

            var DropExtents = Command("DropExtents", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape210),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    Optional(
                        fragment42),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var DropExtents2 = Command("DropExtents", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD("Query", CompletionHint.Tabular)}));

            var DropExtents3 = Command("DropExtents", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment39,
                            Custom(
                                If(Not(Token("all")), rules.TableNameReference),
                                shape29)),
                        missing55),
                    Optional(
                        fragment40),
                    Optional(
                        fragment41),
                    shape255));

            var DropExtents4 = Command("DropExtents", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    RequiredToken("older"),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken("days", "hours"),
                    RequiredToken("from"),
                    Required(
                        First(
                            fragment39,
                            Custom(
                                If(Not(Token("all")), rules.TableNameReference),
                                shape29)),
                        missing56),
                    Optional(
                        fragment40),
                    Optional(
                        fragment41),
                    new [] {CD(), CD(), CD(), CD("Older", CompletionHint.Literal), CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var DropExtentsPartitionMetadata = Command("DropExtentsPartitionMetadata", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    Token("partition"),
                    RequiredToken("metadata"),
                    RequiredToken("from"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Optional(
                        Custom(
                            Token("between"),
                            RequiredToken("("),
                            Required(rules.Value, rules.MissingValue),
                            RequiredToken(".."),
                            Required(rules.Value, rules.MissingValue),
                            RequiredToken(")"),
                            new [] {CD(), CD(), CD("d1", CompletionHint.Literal), CD(), CD("d2", CompletionHint.Literal), CD()})),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD(isOptional: true), CD("csl")}));

            var DropExtents5 = Command("DropExtents", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extents"),
                    RequiredToken("whatif"),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD(), CD("Query", CompletionHint.Tabular)}));

            var DropExtentTagsRetention = Command("DropExtentTagsRetention", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extent"),
                    Token("tags"),
                    RequiredToken("retention")));

            var DropExtent = Command("DropExtent", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("extent"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    Optional(
                        fragment42),
                    new [] {CD(), CD(), CD("ExtentId", CompletionHint.Literal), CD(isOptional: true)}));

            var DropExternalTableAdmins = Command("DropExternalTableAdmins", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("drop", CompletionKind.CommandPrefix),
                        Token("external"),
                        Token("table"),
                        rules.ExternalTableNameReference,
                        Token("admins"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    shape5),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(Token("skip-results")),
                        Optional(
                            Custom(
                                rules.StringLiteral,
                                shape6))}
                    ,
                    shape213));

            var DropExternalTableMapping = Command("DropExternalTableMapping", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape272));

            var DropExternalTable = Command("DropExternalTable", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    shape273));

            var DropFabricServiceAssignmentsCommand = Command("DropFabricServiceAssignmentsCommand", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("fabric"),
                    RequiredToken("service"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("assignments"),
                    shape215));

            var DropFollowerDatabases = Command("DropFollowerDatabases", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("databases"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseNameReference,
                                shape77),
                            fnMissingElement: rules.MissingNameReference),
                        missing33),
                    RequiredToken(")"),
                    RequiredToken("from"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.Database), CD(), CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal)}));

            var DropFollowerDatabases2 = Command("DropFollowerDatabases", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Token("database"),
                    rules.DatabaseNameReference,
                    Token("from"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD("leaderClusterMetadataPath", CompletionHint.Literal)}));

            var DropFollowerDatabaseAuthorizedPrincipals = Command("DropFollowerDatabaseAuthorizedPrincipals", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("follower"),
                    RequiredToken("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "monitors", "unrestrictedviewers", "users", "viewers"),
                    Optional(
                        fragment22),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape5),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD("dbName", CompletionHint.Database), CD("operationRole"), CD(isOptional: true), CD(), CD(CompletionHint.Literal), CD()}));

            var DropFunctions = Command("DropFunctions", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("functions"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseFunctionNameReference,
                                shape127),
                            fnMissingElement: rules.MissingNameReference),
                        missing33),
                    RequiredToken(")"),
                    Optional(Token("ifexists")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Function), CD(), CD(isOptional: true)}));

            var DropFunctionRole = Command("DropFunctionRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape217));

            var DropFunction = Command("DropFunction", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    RequiredToken("ifexists"),
                    shape218));

            var DropFunction2 = Command("DropFunction", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    shape275));

            var DropMaterializedViewAdmins = Command("DropMaterializedViewAdmins", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape5),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape6)),
                    shape220));

            var DropMaterializedView = Command("DropMaterializedView", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape221));

            var DropRowStore2 = Command("DropRowStore", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(Token("ifexists")),
                    shape222));

            var StoredQueryResultsDrop = Command("StoredQueryResultsDrop", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("stored_query_results"),
                    RequiredToken("by"),
                    RequiredToken("user"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("Principal", CompletionHint.Literal)}));

            var StoredQueryResultDrop = Command("StoredQueryResultDrop", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("StoredQueryResultName", CompletionHint.None)}));

            var DropStoredQueryResultContainers = Command("DropStoredQueryResultContainers", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("storedqueryresultcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    Required(
                        OneOrMoreList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape223)),
                        missing38),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(CompletionHint.Literal)}));

            var DropTables = Command("DropTables", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("tables"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.TableNameReference,
                                shape29),
                            fnMissingElement: rules.MissingNameReference),
                        missing33),
                    RequiredToken(")"),
                    Optional(Token("ifexists")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(isOptional: true)}));

            var DropTableRole = Command("DropTableRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("admins"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape224));

            var DropTableColumns = Command("DropTableColumns", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("columns"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.ColumnNameReference,
                                shape39),
                            fnMissingElement: rules.MissingNameReference),
                        missing33),
                    RequiredToken(")"),
                    shape158));

            var DropExtentTagsFromTable2 = Command("DropExtentTagsFromTable", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("extent"),
                    Token("tags"),
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape51),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        fragment5),
                    new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var DropExtentTagsFromQuery3 = Command("DropExtentTagsFromQuery", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("extent"),
                    RequiredToken("tags"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD("csl")}));

            var DropExtentTagsFromQuery4 = Command("DropExtentTagsFromQuery", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("drop", CompletionKind.CommandPrefix),
                        Token("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("extent"),
                        RequiredToken("tags"),
                        RequiredToken("with"),
                        RequiredToken("("),
                        ZeroOrMoreCommaList(
                            fragment0),
                        RequiredToken(")"),
                        Required(
                            fragment6,
                            missing1)}
                    ,
                    new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD(), CD(), CD(), CD(), CD(CompletionHint.None), CD(), CD("csl")}));

            var DropTable = Command("DropTable", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("ifexists"),
                    shape225));

            var DropTableIngestionMapping = Command("DropTableIngestionMapping", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("ingestion"),
                    RequiredToken("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("MappingKind"), CD(), CD("MappingName", CompletionHint.Literal)}));

            var DropTableRole2 = Command("DropTableRole", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("ingestors"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.StringLiteral,
                                shape2),
                            fnMissingElement: rules.MissingStringLiteral),
                        missing0),
                    RequiredToken(")"),
                    Optional(
                        Custom(
                            Token("skip-results"),
                            shape3)),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape4)),
                    shape224));

            var DropTable2 = Command("DropTable", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    shape285));

            var DropTempStorage = Command("DropTempStorage", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("tempstorage"),
                    RequiredToken("older"),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD(), CD("olderThan", CompletionHint.Literal)}));

            var DropUnusedStoredQueryResultContainers = Command("DropUnusedStoredQueryResultContainers", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    Token("unused"),
                    RequiredToken("storedqueryresultcontainers"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    new [] {CD(), CD(), CD(), CD("databaseName", CompletionHint.Database)}));

            var DropWorkloadGroup = Command("DropWorkloadGroup", 
                Custom(
                    Token("drop", CompletionKind.CommandPrefix),
                    RequiredToken("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("WorkloadGroupName", CompletionHint.None)}));

            var EnableContinuousExport = Command("EnableContinuousExport", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape226));

            var EnableDatabaseStreamingIngestionMaintenanceMode = Command("EnableDatabaseStreamingIngestionMaintenanceMode", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("streamingingestion_maintenance_mode")));

            var EnableDatabaseMaintenanceMode = Command("EnableDatabaseMaintenanceMode", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(If(Not(Token("streamingingestion_maintenance_mode")), rules.DatabaseNameReference), rules.MissingNameReference),
                    RequiredToken("maintenance_mode"),
                    shape203));

            var EnableDisableMaterializedView2 = Command("EnableDisableMaterializedView", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape221));

            var EnablePlugin = Command("EnablePlugin", 
                Custom(
                    Token("enable", CompletionKind.CommandPrefix),
                    RequiredToken("plugin"),
                    Required(
                        First(
                            rules.StringLiteral,
                            rules.NameDeclaration),
                        rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("name", CompletionHint.Literal)}));

            var ExecuteClusterScript = Command("ExecuteClusterScript", 
                Custom(
                    Token("execute", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("script"),
                    Optional(
                        fragment43),
                    RequiredToken("<|"),
                    Required(rules.ScriptInput, rules.MissingStatement),
                    shape227));

            var ExecuteDatabaseScript = Command("ExecuteDatabaseScript", 
                Custom(
                    Token("execute", CompletionKind.CommandPrefix),
                    RequiredToken("database"),
                    RequiredToken("script"),
                    Optional(
                        fragment43),
                    RequiredToken("<|"),
                    Required(rules.ScriptInput, rules.MissingStatement),
                    shape227));

            var ExecuteDatabaseScript2 = Command("ExecuteDatabaseScript", 
                Custom(
                    Token("execute", CompletionKind.CommandPrefix),
                    RequiredToken("script"),
                    Optional(
                        fragment43),
                    RequiredToken("<|"),
                    Required(rules.ScriptInput, rules.MissingStatement),
                    new [] {CD(), CD(), CD(isOptional: true), CD(), CD(CompletionHint.Tabular)}));

            var ExportToStorage = Command("ExportToStorage", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("export", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        RequiredToken("compressed"),
                        RequiredToken("to"),
                        RequiredToken("csv", "json", "parquet", "tsv"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    CD("DataConnectionString", CompletionHint.Literal)),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment7),
                        RequiredToken("<|"),
                        Required(rules.QueryInput, rules.MissingExpression)}
                    ,
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var ExportToStorage2 = Command("ExportToStorage", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("export", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        RequiredToken("to"),
                        RequiredToken("csv"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    CD("DataConnectionString", CompletionHint.Literal)),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment7),
                        RequiredToken("<|"),
                        Required(rules.QueryInput, rules.MissingExpression)}
                    ,
                    shape228));

            var ExportToStorage3 = Command("ExportToStorage", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("export", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        RequiredToken("to"),
                        RequiredToken("json"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    CD("DataConnectionString", CompletionHint.Literal)),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment7),
                        RequiredToken("<|"),
                        Required(rules.QueryInput, rules.MissingExpression)}
                    ,
                    shape228));

            var ExportToStorage4 = Command("ExportToStorage", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("export", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        RequiredToken("to"),
                        RequiredToken("parquet"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    CD("DataConnectionString", CompletionHint.Literal)),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment7),
                        RequiredToken("<|"),
                        Required(rules.QueryInput, rules.MissingExpression)}
                    ,
                    shape228));

            var ExportToSqlTable = Command("ExportToSqlTable", 
                Custom(
                    Token("export", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Token("to"),
                    Token("sql"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD("SqlTableName", CompletionHint.None), CD("SqlConnectionString", CompletionHint.Literal), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var ExportToExternalTable = Command("ExportToExternalTable", 
                Custom(
                    Token("export", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Token("to"),
                    Token("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    Optional(
                        fragment7),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var ExportToStorage5 = Command("ExportToStorage", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("export", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        RequiredToken("to"),
                        RequiredToken("tsv"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.StringLiteral,
                                    CD("DataConnectionString", CompletionHint.Literal)),
                                fnMissingElement: rules.MissingStringLiteral),
                            missing0),
                        RequiredToken(")"),
                        Optional(
                            fragment7),
                        RequiredToken("<|"),
                        Required(rules.QueryInput, rules.MissingExpression)}
                    ,
                    shape228));

            var IngestIntoTable = Command("IngestIntoTable", 
                Custom(
                    Token("ingest", CompletionKind.CommandPrefix),
                    RequiredToken("async"),
                    RequiredToken("into"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            fragment46,
                            Custom(
                                rules.StringLiteral,
                                shape168)),
                        missing2),
                    Optional(
                        fragment44),
                    new [] {CD(), CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true)}));

            var IngestInlineIntoTable = Command("IngestInlineIntoTable", 
                Custom(
                    Token("ingest", CompletionKind.CommandPrefix),
                    Token("inline"),
                    RequiredToken("into"),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        First(
                            Custom(
                                Token("["),
                                Required(rules.BracketedInputText, rules.MissingInputText),
                                RequiredToken("]"),
                                new [] {CD(), CD("Data", CompletionHint.None), CD()}),
                            Custom(
                                Token("<|"),
                                Required(rules.InputText, rules.MissingInputText),
                                new [] {CD(), CD("Data", CompletionHint.None)}),
                            Custom(
                                Token("with"),
                                RequiredToken("("),
                                Required(
                                    OneOrMoreCommaList(
                                        fragment45),
                                    missing36),
                                RequiredToken(")"),
                                RequiredToken("<|"),
                                Required(rules.InputText, rules.MissingInputText),
                                new [] {CD(), CD(), CD(), CD(), CD(), CD("Data", CompletionHint.None)})),
                        missing58),
                    new [] {CD(), CD(), CD(), CD(), CD("TableName", CompletionHint.None), CD()}));

            var IngestIntoTable2 = Command("IngestIntoTable", 
                Custom(
                    Token("ingest", CompletionKind.CommandPrefix),
                    RequiredToken("into"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Required(
                        First(
                            fragment46,
                            Custom(
                                rules.StringLiteral,
                                shape168)),
                        missing2),
                    Optional(
                        fragment44),
                    new [] {CD(), CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true)}));

            var MergeExtents = Command("MergeExtents", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    RequiredToken("async"),
                    Required(If(Not(And(Token("async", "database", "dryrun"))), rules.TableNameReference), rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape230),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    Optional(
                        fragment47),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var MergeDatabaseShardGroups = Command("MergeDatabaseShardGroups", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    Token("database").Hide(),
                    RequiredToken("shard-groups").Hide()));

            var MergeExtentsDryrun = Command("MergeExtentsDryrun", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    Token("dryrun"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape230),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(CompletionHint.Literal), CD()}));

            var MergeExtents2 = Command("MergeExtents", 
                Custom(
                    Token("merge", CompletionKind.CommandPrefix),
                    Required(If(Not(And(Token("async", "database", "dryrun"))), rules.TableNameReference), rules.MissingNameReference),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape230),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    Optional(
                        fragment47),
                    new [] {CD(), CD("TableName", CompletionHint.Table), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var MoveExtentsFrom = Command("MoveExtentsFrom", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("move", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        Token("extents"),
                        Token("all"),
                        RequiredToken("from"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("to"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference)}
                    ,
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("SourceTableName", CompletionHint.Table), CD(), CD(), CD("DestinationTableName", CompletionHint.Table)}));

            var MoveExtentsFrom2 = Command("MoveExtentsFrom", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("move", CompletionKind.CommandPrefix),
                        Optional(Token("async")),
                        Token("extents"),
                        Token("from"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        RequiredToken("to"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        Optional(
                            fragment5),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape230),
                                fnMissingElement: rules.MissingValue),
                            missing54),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD("SourceTableName", CompletionHint.Table), CD(), CD(), CD("DestinationTableName", CompletionHint.Table), CD(isOptional: true), CD(), CD(CompletionHint.Literal), CD()}));

            var MoveExtentsQuery = Command("MoveExtentsQuery", 
                Custom(
                    Token("move", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    RequiredToken("extents"),
                    RequiredToken("to"),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Optional(
                        fragment5),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD(), CD("DestinationTableName", CompletionHint.Table), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var PatchExtentCorruptedDatetime = Command("PatchExtentCorruptedDatetime", 
                Custom(
                    Token("patch"),
                    Optional(
                        Custom(
                            Token("table"),
                            Required(rules.TableNameReference, rules.MissingNameReference),
                            new [] {CD(), CD(CompletionHint.Table)})),
                    RequiredToken("extents"),
                    RequiredToken("corrupted"),
                    RequiredToken("datetime"),
                    new [] {CD(), CD(isOptional: true), CD(), CD(), CD()}).Hide());

            var RenameColumns = Command("RenameColumns", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("columns"),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken("="),
                                Required(rules.DatabaseTableColumnNameReference, rules.MissingNameReference),
                                new [] {CD("NewColumnName", CompletionHint.None), CD(), CD("ColumnName", CompletionHint.Column)})),
                        missing59),
                    shape174));

            var RenameColumn = Command("RenameColumn", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(rules.DatabaseTableColumnNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("ColumnName", CompletionHint.Column), CD(), CD("NewColumnName", CompletionHint.None)}));

            var RenameMaterializedView = Command("RenameMaterializedView", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD("NewMaterializedViewName", CompletionHint.None)}));

            var RenameTables = Command("RenameTables", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.NameDeclaration,
                                RequiredToken("="),
                                Required(rules.TableNameReference, rules.MissingNameReference),
                                new [] {CD("NewTableName", CompletionHint.None), CD(), CD("TableName", CompletionHint.Table)})),
                        missing60),
                    shape174));

            var RenameTable = Command("RenameTable", 
                Custom(
                    Token("rename", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("NewTableName", CompletionHint.None)}));

            var ReplaceExtents = Command("ReplaceExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("replace", CompletionKind.CommandPrefix),
                        RequiredToken("async"),
                        RequiredToken("extents"),
                        RequiredToken("in"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        Optional(
                            fragment5),
                        RequiredToken("<|"),
                        RequiredToken("{"),
                        Required(rules.QueryInput, rules.MissingExpression),
                        RequiredToken("}"),
                        RequiredToken(","),
                        RequiredToken("{"),
                        Required(rules.QueryInput, rules.MissingExpression),
                        RequiredToken("}")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("DestinationTableName", CompletionHint.Table), CD(isOptional: true), CD(), CD(), CD("ExtentsToDropQuery", CompletionHint.Tabular), CD(), CD(), CD(), CD("ExtentsToMoveQuery", CompletionHint.Tabular), CD()}));

            var ReplaceDatabaseKeyVaultSecrets = Command("ReplaceDatabaseKeyVaultSecrets", 
                Custom(
                    Token("replace"),
                    Token("database"),
                    RequiredToken("keyvaultsecrets"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD(), CD("secrets", CompletionHint.None)}).Hide());

            var ReplaceExtents2 = Command("ReplaceExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("replace", CompletionKind.CommandPrefix),
                        RequiredToken("extents"),
                        RequiredToken("in"),
                        RequiredToken("table"),
                        Required(rules.TableNameReference, rules.MissingNameReference),
                        Optional(
                            fragment5),
                        RequiredToken("<|"),
                        RequiredToken("{"),
                        Required(rules.QueryInput, rules.MissingExpression),
                        RequiredToken("}"),
                        RequiredToken(","),
                        RequiredToken("{"),
                        Required(rules.QueryInput, rules.MissingExpression),
                        RequiredToken("}")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD("DestinationTableName", CompletionHint.Table), CD(isOptional: true), CD(), CD(), CD("ExtentsToDropQuery", CompletionHint.Tabular), CD(), CD(), CD(), CD("ExtentsToMoveQuery", CompletionHint.Tabular), CD()}));

            var SetOrAppendTable = Command("SetOrAppendTable", 
                Custom(
                    Token("set-or-append", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Required(If(Not(Token("async")), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape238));

            var StoredQueryResultSetOrReplace = Command("StoredQueryResultSetOrReplace", 
                Custom(
                    Token("set-or-replace", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD(), CD("StoredQueryResultName", CompletionHint.None), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var SetOrReplaceTable = Command("SetOrReplaceTable", 
                Custom(
                    Token("set-or-replace", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Required(If(Not(And(Token("async", "stored_query_result"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    shape238));

            var SetAccess = Command("SetAccess", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("access"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("to"),
                    RequiredToken("readonly", "readwrite"),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("AccessMode")}));

            var StoredQueryResultSet = Command("StoredQueryResultSet", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("async"),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(), CD("StoredQueryResultName", CompletionHint.None), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var SetTable = Command("SetTable", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    RequiredToken("async"),
                    Required(If(Not(And(Token("access", "async", "cluster", "continuous-export", "database", "external", "function", "materialized-view", "stored_query_result", "table"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.None), CD(isOptional: true), CD(), CD("QueryOrCommand", CompletionHint.Tabular)}));

            var SetClusterRole = Command("SetClusterRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    RequiredToken("admins", "alldatabasesadmins", "alldatabasesmonitors", "alldatabasesviewers", "databasecreators", "monitors", "ops", "users", "viewers"),
                    Required(
                        First(
                            fragment48,
                            fragment49),
                        missing61),
                    new [] {CD(), CD(), CD("Role"), CD()}));

            var SetContinuousExportCursor = Command("SetContinuousExportCursor", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("cursor"),
                    RequiredToken("to"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("jobName", CompletionHint.None), CD(), CD(), CD("cursorValue", CompletionHint.Literal)}));

            var SetDatabaseRole = Command("SetDatabaseRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("database"),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors", "monitors", "unrestrictedviewers", "users", "viewers"),
                    Required(
                        First(
                            fragment48,
                            fragment49),
                        missing61),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD("Role"), CD()}));

            var SetExternalTableAdmins = Command("SetExternalTableAdmins", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.StringLiteral,
                                            shape5),
                                        fnMissingElement: rules.MissingStringLiteral),
                                    missing0),
                                RequiredToken(")"),
                                Optional(Token("skip-results")),
                                Optional(
                                    Custom(
                                        rules.StringLiteral,
                                        shape6)),
                                shape239),
                            Custom(
                                Token("none"),
                                Optional(Token("skip-results")),
                                shape240)),
                        missing61),
                    new [] {CD(), CD(), CD(), CD("externalTableName", CompletionHint.ExternalTable), CD(), CD()}));

            var SetFunctionRole = Command("SetFunctionRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    RequiredToken("admins"),
                    Required(
                        First(
                            fragment48,
                            fragment49),
                        missing61),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD("Role"), CD()}));

            var SetMaterializedViewAdmins = Command("SetMaterializedViewAdmins", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("admins"),
                    Required(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.StringLiteral,
                                            shape5),
                                        fnMissingElement: rules.MissingStringLiteral),
                                    missing0),
                                RequiredToken(")"),
                                Optional(
                                    Custom(
                                        rules.StringLiteral,
                                        shape6)),
                                new [] {CD(), CD(CompletionHint.Literal), CD(), CD(CompletionHint.Literal, isOptional: true)}),
                            Token("none")),
                        missing62),
                    new [] {CD(), CD(), CD("materializedViewName", CompletionHint.MaterializedView), CD(), CD()}));

            var SetMaterializedViewConcurrency = Command("SetMaterializedViewConcurrency", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("concurrency"),
                    Optional(
                        Custom(
                            Token("="),
                            Required(
                                First(
                                    rules.Value,
                                    rules.Value),
                                rules.MissingValue),
                            new [] {CD(), CD("n", CompletionHint.Literal)})),
                    shape278));

            var SetMaterializedViewCursor = Command("SetMaterializedViewCursor", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    RequiredToken("cursor"),
                    RequiredToken("to"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(), CD("CursorValue", CompletionHint.Literal)}));

            var StoredQueryResultSet2 = Command("StoredQueryResultSet", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD("StoredQueryResultName", CompletionHint.None), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var SetTableRowStoreReferences = Command("SetTableRowStoreReferences", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.DatabaseTableNameReference,
                    RequiredToken("rowstore_references"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("references", CompletionHint.Literal)}));

            var SetTableRole = Command("SetTableRole", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("admins", "ingestors"),
                    Required(
                        First(
                            fragment48,
                            fragment49),
                        missing61),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD("Role"), CD()}));

            var SetTable2 = Command("SetTable", 
                Custom(
                    Token("set", CompletionKind.CommandPrefix),
                    Required(If(Not(And(Token("access", "async", "cluster", "continuous-export", "database", "external", "function", "materialized-view", "stored_query_result", "table"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    Optional(
                        fragment44),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD("TableName", CompletionHint.None), CD(isOptional: true), CD(), CD("QueryOrCommand", CompletionHint.Tabular)}));

            var ShowBasicAuthUsers = Command("ShowBasicAuthUsers", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("basicauth"),
                    RequiredToken("users")));

            var ShowCache = Command("ShowCache", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cache")));

            var ShowCallStacks = Command("ShowCallStacks", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("callstacks"),
                    Optional(
                        fragment7),
                    shape187));

            var ShowCapacity = Command("ShowCapacity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("capacity"),
                    Optional(
                        Custom(
                            Token("data-export", "mirroring", "extents-merge", "extents-partition", "ingestions", "materialized-view", "periodic-storage-artifacts-cleanup", "purge-storage-artifacts-cleanup", "queries", "stored-query-results", "streaming-ingestion-post-processing", "table-purge"),
                            CD("Resource"))),
                    Optional(
                        fragment62),
                    new [] {CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowCertificates = Command("ShowCertificates", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("certificates")));

            var ShowCloudSettings = Command("ShowCloudSettings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cloudsettings")));

            var ShowClusterAdminState = Command("ShowClusterAdminState", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("admin"),
                    RequiredToken("state")));

            var ShowClusterBlockedPrincipals = Command("ShowClusterBlockedPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("blockedprincipals")));

            var ShowClusterDatabases = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("databases"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    rules.WildcardedNameDeclaration,
                                    rules.DatabaseNameReference),
                                shape182),
                            fnMissingElement: rules.MissingNameDeclaration),
                        missing29),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.None), CD()}));

            var ShowClusterDatabasesDataStats = Command("ShowClusterDatabasesDataStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("databases"),
                    Token("datastats")));

            var ShowClusterDatabasesDetails = Command("ShowClusterDatabasesDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("databases"),
                    Token("details")));

            var ShowClusterDatabasesIdentity = Command("ShowClusterDatabasesIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("databases"),
                    Token("identity")));

            var ShowClusterDatabasesPolicies = Command("ShowClusterDatabasesPolicies", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("databases"),
                    Token("policies")));

            var ShowClusterDatabases2 = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("databases")));

            var ShowClusterDetails = Command("ShowClusterDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("details")));

            var ShowClusterExtentsMetadata = Command("ShowClusterExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("extents"),
                    Optional(
                        fragment53),
                    Optional(Token("hot")),
                    Token("metadata"),
                    Optional(
                        fragment54),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowClusterExtents = Command("ShowClusterExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    RequiredToken("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowClusterExtents2 = Command("ShowClusterExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("cluster"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowClusterExtents3 = Command("ShowClusterExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    shape254));

            var ShowIngestionMappings = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("ingestion"),
                    Optional(
                        Custom(
                            Token("apacheavro", "avro", "csv", "json", "orc", "parquet", "sstream", "w3clogfile"),
                            shape46)),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD(), CD(isOptional: true)}));

            var ShowClusterJournal = Command("ShowClusterJournal", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("journal")));

            var ShowClusterMonitoring = Command("ShowClusterMonitoring", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("monitoring")));

            var ShowClusterNetwork = Command("ShowClusterNetwork", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("network"),
                    Optional(
                        Custom(
                            rules.Value,
                            CD("bytes", CompletionHint.Literal))),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var ShowClusterPendingContinuousExports = Command("ShowClusterPendingContinuousExports", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("pending"),
                    RequiredToken("continuous-exports"),
                    Optional(
                        fragment7),
                    shape245));

            var ShowClusterPolicyCaching = Command("ShowClusterPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("caching")));

            var ShowClusterPolicyCallout = Command("ShowClusterPolicyCallout", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("callout")));

            var ShowClusterPolicyCapacity = Command("ShowClusterPolicyCapacity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("capacity")));

            var ShowClusterPolicyDiagnostics = Command("ShowClusterPolicyDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("diagnostics")));

            var ShowClusterPolicyIngestionBatching = Command("ShowClusterPolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("ingestionbatching")));

            var ShowClusterPolicyManagedIdentity = Command("ShowClusterPolicyManagedIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("managed_identity")));

            var ShowClusterPolicyMultiDatabaseAdmins = Command("ShowClusterPolicyMultiDatabaseAdmins", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("multidatabaseadmins")));

            var ShowClusterPolicyQueryWeakConsistency = Command("ShowClusterPolicyQueryWeakConsistency", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("query_weak_consistency")));

            var ShowClusterPolicyRequestClassification = Command("ShowClusterPolicyRequestClassification", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("request_classification")));

            var ShowClusterPolicyRowStore = Command("ShowClusterPolicyRowStore", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("rowstore")));

            var ShowClusterPolicySandbox = Command("ShowClusterPolicySandbox", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sandbox")));

            var ShowClusterPolicySharding = Command("ShowClusterPolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    Token("sharding"),
                    Optional(
                        fragment7),
                    shape245));

            var ShowClusterPolicyStreamingIngestion = Command("ShowClusterPolicyStreamingIngestion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("policy"),
                    RequiredToken("streamingingestion")));

            var ShowClusterPrincipals = Command("ShowClusterPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("principals")));

            var ShowClusterPrincipalRoles = Command("ShowClusterPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment59),
                        missing64),
                    Optional(
                        fragment7),
                    shape245));

            var ShowClusterSandboxesStats = Command("ShowClusterSandboxesStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("sandboxes"),
                    RequiredToken("stats")));

            var ShowClusterScaleIn = Command("ShowClusterScaleIn", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("scalein"),
                    Required(
                        First(
                            rules.Value,
                            rules.Value),
                        rules.MissingValue),
                    RequiredToken("nodes"),
                    new [] {CD(), CD(), CD(), CD("num", CompletionHint.Literal), CD()}));

            var ShowSchema = Command("ShowSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("schema"),
                    Optional(
                        First(
                            fragment64,
                            Token("details"))),
                    shape251));

            var ShowClusterServices = Command("ShowClusterServices", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("services")));

            var ShowClusterStorageKeysHash = Command("ShowClusterStorageKeysHash", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster"),
                    Token("storage"),
                    RequiredToken("keys"),
                    RequiredToken("hash")));

            var ShowCluster = Command("ShowCluster", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("cluster")));

            var ShowColumnPolicyCaching = Command("ShowColumnPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("column"),
                    Token("*"),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    new [] {CD(), CD(), CD("ColumnName"), CD(), CD()}));

            var ShowColumnPolicyCaching2 = Command("ShowColumnPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("column"),
                    If(Not(Token("*")), rules.DatabaseTableColumnNameReference),
                    RequiredToken("policy"),
                    RequiredToken("caching"),
                    shape191));

            var ShowColumnPolicyEncoding = Command("ShowColumnPolicyEncoding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("column"),
                    Required(If(Not(Token("*")), rules.TableColumnNameReference), rules.MissingNameReference),
                    RequiredToken("policy"),
                    RequiredToken("encoding"),
                    shape191));

            var ShowCommandsAndQueries = Command("ShowCommandsAndQueries", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commands-and-queries")));

            var ShowCommands = Command("ShowCommands", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commands")));

            var ShowCommConcurrency = Command("ShowCommConcurrency", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commconcurrency")));

            var ShowCommPools = Command("ShowCommPools", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("commpools")));

            var ShowContinuousExports = Command("ShowContinuousExports", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-exports")));

            var ShowContinuousExportExportedArtifacts = Command("ShowContinuousExportExportedArtifacts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    rules.NameDeclaration,
                    Token("exported-artifacts"),
                    shape246));

            var ShowContinuousExportFailures = Command("ShowContinuousExportFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    rules.NameDeclaration,
                    Token("failures"),
                    shape246));

            var ShowContinuousExport = Command("ShowContinuousExport", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("continuous-export"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    shape226));

            var ShowClusterDatabases3 = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    RequiredToken("("),
                    Required(rules.WildcardedNameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        Custom(
                            Token(","),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        First(
                                            rules.WildcardedNameDeclaration,
                                            rules.DatabaseNameReference),
                                        shape182),
                                    fnMissingElement: rules.MissingNameDeclaration),
                                missing29),
                            new [] {CD(), CD(CompletionHint.None)})),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.None), CD(isOptional: true), CD()}));

            var ShowDatabaseExtentsMetadata = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment53),
                        Optional(Token("hot")),
                        Token("metadata"),
                        Optional(
                            fragment54),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtents = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("where"),
                        Required(
                            OneOrMoreList(
                                fragment50,
                                separatorParser: Token("and")),
                            missing63),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtents2 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents3 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    rules.DatabaseNameReference,
                    Token(")"),
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabasesSchemaAsJson = Command("ShowDatabasesSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    rules.DatabaseNameReference,
                    Token(")"),
                    Token("schema"),
                    Token("as"),
                    RequiredToken("json"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD()}));

            var ShowDatabasesSchema = Command("ShowDatabasesSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken(")"),
                    RequiredToken("schema"),
                    RequiredToken("details"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD()}));

            var ShowDatabasesSchema2 = Command("ShowDatabasesSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken(")"),
                    RequiredToken("schema"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD()}));

            var ShowClusterDatabases4 = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    RequiredToken("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD()}));

            var ShowDatabaseExtentsMetadata2 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(","),
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseNameReference,
                                shape11),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment53),
                        Optional(Token("hot")),
                        Token("metadata"),
                        Optional(
                            fragment54),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtents4 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(","),
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseNameReference,
                                shape11),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("where"),
                        Required(
                            OneOrMoreList(
                                fragment50,
                                separatorParser: Token("and")),
                            missing63),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtents5 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(","),
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseNameReference,
                                shape11),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents6 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(","),
                        OneOrMoreCommaList(
                            Custom(
                                rules.DatabaseNameReference,
                                shape11),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot"))}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabasesSchemaAsJson2 = Command("ShowDatabasesSchemaAsJson", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token(","),
                        OneOrMoreCommaList(
                            fragment56),
                        Token(")"),
                        Token("schema"),
                        Token("as"),
                        RequiredToken("json")}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD(), CD(), CD()}));

            var ShowDatabasesSchema3 = Command("ShowDatabasesSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken(","),
                    Required(
                        OneOrMoreCommaList(
                            fragment55),
                        missing65),
                    RequiredToken(")"),
                    RequiredToken("schema"),
                    RequiredToken("details"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD(), CD()}));

            var ShowDatabasesSchema4 = Command("ShowDatabasesSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken(","),
                    Required(
                        OneOrMoreCommaList(
                            fragment55),
                        missing65),
                    RequiredToken(")"),
                    RequiredToken("schema"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.Database), CD(), CD()}));

            var ShowClusterDatabases5 = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    RequiredToken("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken(","),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                First(
                                    rules.WildcardedNameDeclaration,
                                    rules.DatabaseNameReference),
                                shape182),
                            fnMissingElement: rules.MissingNameDeclaration),
                        missing29),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(CompletionHint.None), CD()}));

            var ShowDatabasesSchemaAsJson3 = Command("ShowDatabasesSchemaAsJson", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        rules.DatabaseNameReference,
                        Token("if_later_than"),
                        rules.StringLiteral,
                        Optional(
                            Custom(
                                Token(","),
                                OneOrMoreCommaList(
                                    fragment56),
                                shape250)),
                        Token(")"),
                        Token("schema"),
                        Token("as"),
                        RequiredToken("json")}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("Version", CompletionHint.Literal), CD(isOptional: true), CD(), CD(), CD(), CD()}));

            var ShowDatabasesSchema5 = Command("ShowDatabasesSchema", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("databases"),
                        Token("("),
                        Required(rules.DatabaseNameReference, rules.MissingNameReference),
                        RequiredToken("if_later_than"),
                        Required(rules.StringLiteral, rules.MissingStringLiteral),
                        Optional(
                            fragment57),
                        RequiredToken(")"),
                        RequiredToken("schema"),
                        RequiredToken("details")}
                    ,
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("Version", CompletionHint.Literal), CD(isOptional: true), CD(), CD(), CD()}));

            var ShowDatabasesSchema6 = Command("ShowDatabasesSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("("),
                    Required(rules.DatabaseNameReference, rules.MissingNameReference),
                    RequiredToken("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment57),
                    RequiredToken(")"),
                    RequiredToken("schema"),
                    new [] {CD(), CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("Version", CompletionHint.Literal), CD(isOptional: true), CD(), CD()}));

            var ShowClusterDatabasesDataStats2 = Command("ShowClusterDatabasesDataStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("datastats")));

            var ShowClusterDatabasesDetails2 = Command("ShowClusterDatabasesDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("details")));

            var ShowDatabasesEntities = Command("ShowDatabasesEntities", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("entities"),
                    Optional(
                        fragment5),
                    shape251));

            var ShowClusterDatabasesIdentity2 = Command("ShowClusterDatabasesIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("identity")));

            var ShowDatabasesManagementGroups = Command("ShowDatabasesManagementGroups", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("management"),
                    RequiredToken("groups")));

            var ShowClusterDatabasesPolicies2 = Command("ShowClusterDatabasesPolicies", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases"),
                    Token("policies")));

            var ShowClusterDatabases6 = Command("ShowClusterDatabases", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("databases")));

            var ShowDatabasePolicyCaching = Command("ShowDatabasePolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    Token("policy"),
                    Token("caching"),
                    shape253));

            var ShowDatabasePolicyExtentTagsRetention = Command("ShowDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape253));

            var ShowDatabasePolicyIngestionBatching = Command("ShowDatabasePolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape253));

            var ShowDatabasePolicyMerge = Command("ShowDatabasePolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    Token("policy"),
                    Token("merge"),
                    shape253));

            var ShowDatabasePolicyRetention = Command("ShowDatabasePolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    Token("policy"),
                    Token("retention"),
                    shape253));

            var ShowDatabasePolicySharding = Command("ShowDatabasePolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    Token("policy"),
                    Token("sharding"),
                    shape253));

            var ShowDatabasePolicyShardsGrouping = Command("ShowDatabasePolicyShardsGrouping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("*"),
                    RequiredToken("policy"),
                    RequiredToken("shards_grouping").Hide(),
                    shape253));

            var ShowDatabaseCacheQueryResults = Command("ShowDatabaseCacheQueryResults", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cache"),
                    RequiredToken("query_results")));

            var ShowDatabaseCslSchema = Command("ShowDatabaseCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("cslschema"),
                    Optional(Token("script")),
                    Optional(
                        fragment58),
                    shape254));

            var ShowDatabaseDataStats = Command("ShowDatabaseDataStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("datastats")));

            var ShowDatabaseDetails = Command("ShowDatabaseDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("details")));

            var ShowDatabaseExtentsMetadata3 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        Token("extents"),
                        Token("("),
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape210),
                            fnMissingElement: rules.MissingValue),
                        Token(")"),
                        Optional(Token("hot")),
                        Token("metadata"),
                        Optional(
                            fragment54),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtents7 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        Token("extents"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape210),
                                fnMissingElement: rules.MissingValue),
                            missing54),
                        RequiredToken(")"),
                        Optional(Token("hot")),
                        RequiredToken("where"),
                        Required(
                            OneOrMoreList(
                                fragment50,
                                separatorParser: Token("and")),
                            missing63),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtents8 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        Token("extents"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape210),
                                fnMissingElement: rules.MissingValue),
                            missing54),
                        RequiredToken(")"),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents9 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape210),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    Optional(Token("hot")),
                    new [] {CD(), CD(), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtentsMetadata4 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    Token("hot"),
                    Token("metadata"),
                    Optional(
                        fragment54),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtents10 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    RequiredToken("hot"),
                    RequiredToken("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63),
                    Optional(
                        fragment51),
                    shape260));

            var ShowDatabaseExtents11 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        Token("extents"),
                        RequiredToken("hot"),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents12 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    RequiredToken("hot")));

            var ShowDatabaseExtentsMetadata5 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    Token("metadata"),
                    Optional(
                        fragment54),
                    Optional(
                        fragment51),
                    shape255));

            var ShowDatabaseExtentsPartitioningStatistics = Command("ShowDatabaseExtentsPartitioningStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    Token("partitioning"),
                    RequiredToken("statistics")));

            var ShowDatabaseExtents13 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    RequiredToken("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63),
                    Optional(
                        fragment51),
                    shape256));

            var ShowDatabaseExtents14 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents"),
                    RequiredToken("with"),
                    RequiredToken("("),
                    RequiredToken("extentsShowFilteringRuntimePolicy"),
                    RequiredToken("="),
                    Required(rules.Value, rules.MissingValue),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents15 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extents")));

            var ShowDatabaseExtentTagsStatistics = Command("ShowDatabaseExtentTagsStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("extent"),
                    RequiredToken("tags"),
                    RequiredToken("statistics"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            RequiredToken("minCreationTime"),
                            RequiredToken("="),
                            Required(rules.Value, rules.MissingValue),
                            RequiredToken(")"),
                            new [] {CD(), CD(), CD(), CD(), CD("minCreationTime", CompletionHint.Literal), CD()})),
                    shape256));

            var ShowDatabaseIdentity = Command("ShowDatabaseIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("identity")));

            var ShowDatabaseIngestionMappings = Command("ShowDatabaseIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("ingestion"),
                    Optional(
                        Custom(
                            Token("apacheavro", "avro", "csv", "json", "orc", "parquet", "sstream", "w3clogfile"),
                            shape46)),
                    RequiredToken("mappings"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape257)),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD(), CD(isOptional: true), CD(), CD(CompletionHint.Literal, isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseKeyVaultSecrets = Command("ShowDatabaseKeyVaultSecrets", 
                Custom(
                    Token("show"),
                    Token("database"),
                    Token("keyvault"),
                    RequiredToken("secrets")).Hide());

            var ShowDatabaseCslSchema2 = Command("ShowDatabaseCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("kqlschema"),
                    Optional(Token("script")),
                    Optional(
                        fragment58),
                    shape254));

            var ShowDatabasePolicies = Command("ShowDatabasePolicies", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("policies")));

            var ShowDatabasePrincipals = Command("ShowDatabasePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("principals")));

            var ShowDatabaseSchemaAsCslScript = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("as"),
                    RequiredToken("csl"),
                    RequiredToken("script"),
                    Optional(
                        fragment7),
                    shape260));

            var ShowDatabaseSchemaAsJson = Command("ShowDatabaseSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("as"),
                    Token("json")));

            var ShowDatabaseSchemaAsCslScript2 = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("as"),
                    RequiredToken("kql"),
                    RequiredToken("script"),
                    Optional(
                        fragment7),
                    shape260));

            var ShowDatabaseSchema = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    RequiredToken("details"),
                    Optional(
                        fragment58),
                    shape245));

            var ShowDatabaseSchemaAsCslScript3 = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("as"),
                    RequiredToken("csl"),
                    RequiredToken("script"),
                    Optional(
                        fragment7),
                    shape261));

            var ShowDatabaseSchemaAsJson2 = Command("ShowDatabaseSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("if_later_than"),
                    rules.StringLiteral,
                    Token("as"),
                    Token("json"),
                    new [] {CD(), CD(), CD(), CD(), CD("Version", CompletionHint.Literal), CD(), CD()}));

            var ShowDatabaseSchemaAsCslScript4 = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("as"),
                    RequiredToken("kql"),
                    RequiredToken("script"),
                    Optional(
                        fragment7),
                    shape261));

            var ShowDatabaseSchema2 = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    RequiredToken("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD(), CD(), CD("databaseVersion", CompletionHint.Literal)}));

            var ShowDatabaseSchemaViolations = Command("ShowDatabaseSchemaViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema"),
                    Token("violations")));

            var ShowDatabaseSchema3 = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("schema")));

            var DatabaseShardGroupsStatisticsShow = Command("DatabaseShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    Token("shard-groups").Hide(),
                    RequiredToken("statistics").Hide()));

            var ShowDatabaseCslSchema3 = Command("ShowDatabaseCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("cslschema"),
                    Optional(Token("script")),
                    Optional(
                        fragment58),
                    shape263));

            var ShowDatabaseEntity = Command("ShowDatabaseEntity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("entity"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        fragment5),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD("EntityName", CompletionHint.None), CD(isOptional: true)}));

            var ShowDatabaseExtentContainersCleanOperations = Command("ShowDatabaseExtentContainersCleanOperations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extentcontainers"),
                    RequiredToken("clean"),
                    RequiredToken("operations"),
                    Optional(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape262)),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD(), CD(CompletionHint.Literal, isOptional: true)}));

            var ShowDatabaseExtentsMetadata6 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                        Token("extents"),
                        Token("("),
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape210),
                            fnMissingElement: rules.MissingValue),
                        Token(")"),
                        Optional(Token("hot")),
                        Token("metadata"),
                        Optional(
                            fragment54),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtents16 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                        Token("extents"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape210),
                                fnMissingElement: rules.MissingValue),
                            missing54),
                        RequiredToken(")"),
                        Optional(Token("hot")),
                        RequiredToken("where"),
                        Required(
                            OneOrMoreList(
                                fragment50,
                                separatorParser: Token("and")),
                            missing63),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtents17 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                        Token("extents"),
                        RequiredToken("("),
                        Required(
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape210),
                                fnMissingElement: rules.MissingValue),
                            missing54),
                        RequiredToken(")"),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents18 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape210),
                            fnMissingElement: rules.MissingValue),
                        missing54),
                    RequiredToken(")"),
                    Optional(Token("hot")),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtentsMetadata7 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    Token("hot"),
                    Token("metadata"),
                    Optional(
                        fragment54),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtents19 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    RequiredToken("hot"),
                    RequiredToken("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtents20 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                        Token("extents"),
                        RequiredToken("hot"),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents21 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    RequiredToken("hot"),
                    shape192));

            var ShowDatabaseExtentsMetadata8 = Command("ShowDatabaseExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    Token("metadata"),
                    Optional(
                        fragment54),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseExtentsPartitioningStatistics2 = Command("ShowDatabaseExtentsPartitioningStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    Token("partitioning"),
                    RequiredToken("statistics"),
                    shape66));

            var ShowDatabaseExtents22 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    RequiredToken("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseExtents23 = Command("ShowDatabaseExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("database"),
                        If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                        Token("extents"),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowDatabaseExtents24 = Command("ShowDatabaseExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("extents"),
                    shape203));

            var ShowDatabaseIngestionMappings2 = Command("ShowDatabaseIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("ingestion"),
                    Optional(
                        Custom(
                            Token("apacheavro", "avro", "csv", "json", "orc", "parquet", "sstream", "w3clogfile"),
                            shape46)),
                    RequiredToken("mappings"),
                    Optional(
                        Custom(
                            rules.StringLiteral,
                            shape257)),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(isOptional: true), CD(), CD(CompletionHint.Literal, isOptional: true), CD(isOptional: true)}));

            var ShowDatabaseJournal = Command("ShowDatabaseJournal", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("journal"),
                    shape203));

            var ShowDatabaseCslSchema4 = Command("ShowDatabaseCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("kqlschema"),
                    Optional(Token("script")),
                    Optional(
                        fragment58),
                    shape263));

            var ShowDatabasePolicyCaching2 = Command("ShowDatabasePolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("caching"),
                    shape192));

            var ShowDatabasePolicyDiagnostics = Command("ShowDatabasePolicyDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("diagnostics"),
                    shape192));

            var ShowDatabasePolicyEncoding = Command("ShowDatabasePolicyEncoding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("encoding"),
                    shape192));

            var ShowDatabasePolicyExtentTagsRetention2 = Command("ShowDatabasePolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape192));

            var ShowDatabasePolicyHardRetentionViolations = Command("ShowDatabasePolicyHardRetentionViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("hardretention"),
                    RequiredToken("violations"),
                    shape264));

            var ShowDatabasePolicyIngestionBatching2 = Command("ShowDatabasePolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape192));

            var ShowDatabasePolicyManagedIdentity = Command("ShowDatabasePolicyManagedIdentity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("managed_identity"),
                    shape192));

            var ShowDatabasePolicyMerge2 = Command("ShowDatabasePolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("merge"),
                    shape192));

            var ShowDatabasePolicyMirroring = Command("ShowDatabasePolicyMirroring", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("mirroring"),
                    shape192));

            var ShowDatabasePolicyRetention2 = Command("ShowDatabasePolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("retention"),
                    shape192));

            var ShowDatabasePolicySharding2 = Command("ShowDatabasePolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("sharding"),
                    shape192));

            var ShowDatabasePolicyShardsGrouping2 = Command("ShowDatabasePolicyShardsGrouping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    RequiredToken("shards_grouping").Hide(),
                    shape192));

            var ShowDatabasePolicySoftRetentionViolations = Command("ShowDatabasePolicySoftRetentionViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("softretention"),
                    RequiredToken("violations"),
                    shape264));

            var ShowDatabasePolicyStreamingIngestion = Command("ShowDatabasePolicyStreamingIngestion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    Token("streamingingestion"),
                    shape192));

            var ShowDatabaseTableMirroringPolicyTemplates = Command("ShowDatabaseTableMirroringPolicyTemplates", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("policy"),
                    RequiredToken("table_mirroring_templates"),
                    shape192));

            var ShowDatabasePrincipals2 = Command("ShowDatabasePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("principals"),
                    shape203));

            var ShowDatabasePrincipalRoles = Command("ShowDatabasePrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment59),
                        missing64),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabasePurgeOperation = Command("ShowDatabasePurgeOperation", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("purge"),
                    Required(
                        First(
                            Custom(
                                Token("operations"),
                                Optional(
                                    Custom(
                                        rules.AnyGuidLiteralOrString,
                                        shape262)),
                                shape92),
                            Custom(
                                Token("operation"),
                                Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                                new [] {CD(), CD("obj", CompletionHint.Literal)})),
                        missing66),
                    shape266));

            var ShowDatabaseSchema4 = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    RequiredToken("details"),
                    Optional(
                        fragment58),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD(isOptional: true)}));

            var ShowDatabaseSchema5 = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    RequiredToken("if_later_than"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD(), CD(), CD("databaseVersion", CompletionHint.Literal)}));

            var ShowDatabaseSchemaViolations2 = Command("ShowDatabaseSchemaViolations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    Token("violations"),
                    shape266));

            var ShowDatabaseSchemaAsCslScript5 = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    Optional(
                        fragment60),
                    RequiredToken("as"),
                    RequiredToken("csl"),
                    RequiredToken("script"),
                    Optional(
                        fragment7),
                    shape267));

            var ShowDatabaseSchemaAsJson3 = Command("ShowDatabaseSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    Optional(
                        fragment61),
                    Token("as"),
                    Token("json"),
                    new [] {CD(), CD(), CD("DatabaseName", CompletionHint.Database), CD(), CD(isOptional: true), CD(), CD()}));

            var ShowDatabaseSchemaAsCslScript6 = Command("ShowDatabaseSchemaAsCslScript", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    Optional(
                        fragment60),
                    RequiredToken("as"),
                    RequiredToken("kql"),
                    RequiredToken("script"),
                    Optional(
                        fragment7),
                    shape267));

            var ShowDatabaseSchema6 = Command("ShowDatabaseSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    Token("schema"),
                    new [] {CD(), CD(), CD("databaseName", CompletionHint.Database), CD()}));

            var DatabaseShardGroupsStatisticsShow2 = Command("DatabaseShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database"),
                    If(Not(And(Token("*", "cache", "cslschema", "datastats", "details", "extents", "extent", "identity", "ingestion", "keyvault", "kqlschema", "policies", "principals", "schema", "shard-groups"))), rules.DatabaseNameReference),
                    RequiredToken("shard-groups").Hide(),
                    RequiredToken("statistics").Hide(),
                    shape192));

            var ShowDatabase = Command("ShowDatabase", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("database")));

            var ShowDataOperations = Command("ShowDataOperations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("data"),
                    RequiredToken("operations")));

            var ShowDiagnostics = Command("ShowDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("diagnostics"),
                    Optional(
                        fragment62),
                    shape187));

            var ShowEntityGroups = Command("ShowEntityGroups", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("entity_groups")));

            var ShowEntityGroup = Command("ShowEntityGroup", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("entity_group"),
                    Required(rules.EntityGroups, rules.MissingNameReference),
                    shape270));

            var ShowEntitySchema = Command("ShowEntitySchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("entity"),
                    Required(rules.QualifiedNameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    Optional(
                        Custom(
                            Token("in"),
                            RequiredToken("databases"),
                            RequiredToken("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.StringLiteral,
                                        CD("item", CompletionHint.Literal)),
                                    fnMissingElement: rules.MissingStringLiteral),
                                missing0),
                            RequiredToken(")"),
                            new [] {CD(), CD(), CD(), CD(CompletionHint.Literal), CD()})),
                    Optional(
                        Custom(
                            Token("except"),
                            Required(rules.StringLiteral, rules.MissingStringLiteral),
                            new [] {CD(), CD("excludedFunctions", CompletionHint.Literal)})),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("entity", CompletionHint.None), CD(), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(isOptional: true)}));

            var ShowExtentContainers = Command("ShowExtentContainers", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("extentcontainers"),
                    Optional(
                        fragment7),
                    shape187));

            var ShowExtentCorruptedDatetime = Command("ShowExtentCorruptedDatetime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("extents"),
                    Required(
                        fragment65,
                        missing67).Hide()));

            var ShowExternalTables = Command("ShowExternalTables", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("tables"),
                    Optional(
                        fragment5),
                    shape251));

            var ShowExternalTableArtifacts = Command("ShowExternalTableArtifacts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("artifacts"),
                    Optional(
                        fragment41),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(isOptional: true)}));

            var ShowExternalTableCslSchema = Command("ShowExternalTableCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("cslschema"),
                    shape271));

            var ShowExternalTableCslSchema2 = Command("ShowExternalTableCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("kqlschema"),
                    shape271));

            var ShowExternalTableMappings = Command("ShowExternalTableMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("mappings"),
                    shape271));

            var ShowExternalTableMapping = Command("ShowExternalTableMapping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    shape272));

            var ShowExternalTablePrincipals = Command("ShowExternalTablePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("principals"),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.ExternalTable), CD()}));

            var ShowExternalTablesPrincipalRoles = Command("ShowExternalTablesPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment59),
                        missing64),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(), CD(isOptional: true)}));

            var ShowExternalTableSchema = Command("ShowExternalTableSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    Token("table"),
                    rules.ExternalTableNameReference,
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("csl", "json", "kql"),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(), CD()}));

            var ShowExternalTable = Command("ShowExternalTable", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    RequiredToken("with"),
                    RequiredToken("("),
                    ZeroOrMoreCommaList(
                        fragment0),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD("ExternalTableName", CompletionHint.ExternalTable), CD(), CD(), CD(CompletionHint.None), CD()}));

            var ShowExternalTable2 = Command("ShowExternalTable", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("external"),
                    RequiredToken("table"),
                    Required(rules.ExternalTableNameReference, rules.MissingNameReference),
                    shape273));

            var ShowFabricCache = Command("ShowFabricCache", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabriccache")));

            var ShowFabricClocks = Command("ShowFabricClocks", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabricclocks")));

            var ShowFabricLocks = Command("ShowFabricLocks", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabriclocks")));

            var ShowFabric = Command("ShowFabric", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("fabric"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("id", CompletionHint.None)}));

            var ShowFeatureFlags = Command("ShowFeatureFlags", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("featureflags")));

            var ShowFollowerDatabase = Command("ShowFollowerDatabase", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("follower"),
                    Required(
                        First(
                            Custom(
                                Token("databases"),
                                Optional(
                                    fragment63),
                                shape240),
                            Custom(
                                Token("database"),
                                Required(rules.DatabaseNameReference, rules.MissingNameReference),
                                new [] {CD(), CD("databaseName", CompletionHint.Database)})),
                        missing68)));

            var ShowFreshness = Command("ShowFreshness", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("freshness").Hide(),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    Optional(
                        Custom(
                            Token("column"),
                            Required(rules.ColumnNameReference, rules.MissingNameReference),
                            new [] {CD(), CD("columnName", CompletionHint.Column)})),
                    Optional(
                        Custom(
                            Token("threshold"),
                            Required(rules.Value, rules.MissingValue),
                            new [] {CD(), CD("threshold", CompletionHint.Literal)})),
                    new [] {CD(), CD(), CD("tableName", CompletionHint.Table), CD(isOptional: true), CD(isOptional: true)}));

            var ShowFunctions = Command("ShowFunctions", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("functions")));

            var ShowFunctionPrincipals = Command("ShowFunctionPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("principals"),
                    shape218));

            var ShowFunctionPrincipalRoles = Command("ShowFunctionPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment59),
                        missing64),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD(), CD(), CD(isOptional: true)}));

            var ShowFunctionSchemaAsJson = Command("ShowFunctionSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    rules.DatabaseFunctionNameReference,
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    Optional(
                        fragment5),
                    new [] {CD(), CD(), CD("functionName", CompletionHint.Function), CD(), CD(), CD(), CD(isOptional: true)}));

            var ShowFunction = Command("ShowFunction", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    RequiredToken("with"),
                    RequiredToken("("),
                    ZeroOrMoreCommaList(
                        fragment0),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD("FunctionName", CompletionHint.Function), CD(), CD(), CD(CompletionHint.None), CD()}));

            var ShowFunction2 = Command("ShowFunction", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("function"),
                    Required(rules.DatabaseFunctionNameReference, rules.MissingNameReference),
                    shape275));

            var ShowIngestionMappings2 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("apacheavro"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionMappings3 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("avro"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionMappings4 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("csv"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionFailures = Command("ShowIngestionFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    Token("failures"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            RequiredToken("OperationId"),
                            RequiredToken("="),
                            Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                            RequiredToken(")"),
                            new [] {CD(), CD(), CD(), CD(), CD("OperationId", CompletionHint.Literal), CD()})),
                    shape251));

            var ShowIngestionMappings5 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("json"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionMappings6 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape251));

            var ShowIngestionMappings7 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("orc"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionMappings8 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("parquet"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionMappings9 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("sstream"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowIngestionMappings10 = Command("ShowIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("ingestion"),
                    RequiredToken("w3clogfile"),
                    RequiredToken("mappings"),
                    Optional(
                        fragment7),
                    shape276));

            var ShowJournal = Command("ShowJournal", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("journal")));

            var ShowMaterializedViewsDetails = Command("ShowMaterializedViewsDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-views"),
                    Token("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.MaterializedViewNameReference,
                                shape25),
                            fnMissingElement: rules.MissingNameReference),
                        missing33),
                    RequiredToken(")"),
                    RequiredToken("details"),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.MaterializedView), CD(), CD()}));

            var ShowMaterializedViewsDetails2 = Command("ShowMaterializedViewsDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-views"),
                    Token("details")));

            var ShowMaterializedViews = Command("ShowMaterializedViews", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-views")));

            var ShowMaterializedViewCslSchema = Command("ShowMaterializedViewCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("cslschema"),
                    shape277));

            var ShowMaterializedViewDetails = Command("ShowMaterializedViewDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("details"),
                    shape277));

            var ShowMaterializedViewDiagnostics = Command("ShowMaterializedViewDiagnostics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("diagnostics"),
                    Optional(
                        fragment7),
                    shape278));

            var ShowMaterializedViewExtents = Command("ShowMaterializedViewExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    new [] {CD(), CD(), CD("MaterializedViewName", CompletionHint.MaterializedView), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowMaterializedViewFailures = Command("ShowMaterializedViewFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("failures"),
                    shape279));

            var ShowMaterializedViewCslSchema2 = Command("ShowMaterializedViewCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("kqlschema"),
                    shape277));

            var ShowMaterializedViewPolicyCaching = Command("ShowMaterializedViewPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("caching"),
                    shape196));

            var ShowMaterializedViewPolicyMerge = Command("ShowMaterializedViewPolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("merge"),
                    shape196));

            var ShowMaterializedViewPolicyPartitioning = Command("ShowMaterializedViewPolicyPartitioning", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("partitioning"),
                    shape196));

            var ShowMaterializedViewPolicyRetention = Command("ShowMaterializedViewPolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    Token("retention"),
                    shape196));

            var ShowMaterializedViewPolicyRowLevelSecurity = Command("ShowMaterializedViewPolicyRowLevelSecurity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape196));

            var ShowMaterializedViewPrincipals = Command("ShowMaterializedViewPrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("principals"),
                    shape277));

            var ShowMaterializedViewSchemaAsJson = Command("ShowMaterializedViewSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    shape132));

            var ShowMaterializedViewStatistics = Command("ShowMaterializedViewStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    rules.MaterializedViewNameReference,
                    Token("statistics"),
                    shape279));

            var ShowMaterializedView = Command("ShowMaterializedView", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("materialized-view"),
                    Required(rules.MaterializedViewNameReference, rules.MissingNameReference),
                    shape221));

            var ShowMemory = Command("ShowMemory", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("memory"),
                    Optional(Token("details")),
                    shape187));

            var ShowMemPools = Command("ShowMemPools", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("mempools")));

            var ShowOperations = Command("ShowOperations", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("operations"),
                    Optional(
                        First(
                            Custom(
                                Token("("),
                                Required(
                                    OneOrMoreCommaList(
                                        Custom(
                                            rules.AnyGuidLiteralOrString,
                                            shape280),
                                        fnMissingElement: rules.MissingValue),
                                    missing54),
                                RequiredToken(")"),
                                shape38),
                            Custom(
                                rules.AnyGuidLiteralOrString,
                                shape280))),
                    shape187));

            var ShowOperationDetails = Command("ShowOperationDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("operation"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    RequiredToken("details"),
                    new [] {CD(), CD(), CD("OperationId", CompletionHint.Literal), CD()}));

            var ShowPlugins = Command("ShowPlugins", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("plugins"),
                    Optional(
                        fragment7),
                    shape187));

            var ShowPrincipalAccess = Command("ShowPrincipalAccess", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("principal"),
                    Token("access"),
                    Optional(
                        fragment7),
                    shape251));

            var ShowPrincipalRoles = Command("ShowPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("principal"),
                    RequiredToken("roles"),
                    Optional(
                        fragment7),
                    shape251));

            var ShowPrincipalRoles2 = Command("ShowPrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("principal"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    RequiredToken("roles"),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD("Principal", CompletionHint.Literal), CD(), CD(isOptional: true)}));

            var ShowQueries = Command("ShowQueries", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("queries")));

            var ShowQueryExecution = Command("ShowQueryExecution", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("queryexecution"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD("queryText")}));

            var ShowQueryPlan = Command("ShowQueryPlan", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("queryplan"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        First(
                                            Token("reconstructCsl"),
                                            Token("showExternalArtifacts"),
                                            If(Not(And(Token("reconstructCsl", "showExternalArtifacts"))), rules.NameDeclaration)),
                                        RequiredToken("="),
                                        Required(rules.Value, rules.MissingValue),
                                        shape129)),
                                missing69),
                            RequiredToken(")"))),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var ShowQueryCallTree = Command("ShowQueryCallTree", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("query"),
                    RequiredToken("call-tree"),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD(), CD("queryText")}));

            var ShowRequestSupport = Command("ShowRequestSupport", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("request_support"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("key", CompletionHint.Literal)}));

            var ShowRowStores = Command("ShowRowStores", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstores")));

            var ShowRowStoreSeals = Command("ShowRowStoreSeals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Token("seals"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(
                        fragment7),
                    new [] {CD(), CD(), CD(), CD("tableName", CompletionHint.Literal), CD(isOptional: true)}));

            var ShowRowStoreTransactions = Command("ShowRowStoreTransactions", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Token("transactions")));

            var ShowRowStore = Command("ShowRowStore", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("rowstore"),
                    Required(If(Not(And(Token("seals", "transactions"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("rowStoreName", CompletionHint.None)}));

            var ShowRunningQueries = Command("ShowRunningQueries", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("running"),
                    RequiredToken("queries"),
                    Optional(
                        Custom(
                            Token("by"),
                            Required(
                                First(
                                    Token("*"),
                                    fragment38),
                                missing15))),
                    shape251));

            var ShowSchema2 = Command("ShowSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("schema"),
                    Optional(
                        First(
                            fragment64,
                            Token("details"))),
                    shape187));

            var ShowServicePoints = Command("ShowServicePoints", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("servicepoints")));

            var StoredQueryResultsShow = Command("StoredQueryResultsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("stored_query_results"),
                    Optional(
                        fragment5),
                    shape187));

            var StoredQueryResultShowSchema = Command("StoredQueryResultShowSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("stored_query_result"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("schema"),
                    new [] {CD(), CD(), CD("StoredQueryResultName", CompletionHint.None), CD()}));

            var ShowStreamingIngestionFailures = Command("ShowStreamingIngestionFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("streamingingestion"),
                    Token("failures")));

            var ShowStreamingIngestionStatistics = Command("ShowStreamingIngestionStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("streamingingestion"),
                    RequiredToken("statistics")));

            var ShowTablesDetails = Command("ShowTablesDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("details"),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD()}));

            var ShowTableExtentsMetadata = Command("ShowTableExtentsMetadata", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("tables"),
                        Token("("),
                        OneOrMoreCommaList(
                            Custom(
                                rules.TableNameReference,
                                shape29),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment53),
                        Optional(Token("hot")),
                        Token("metadata"),
                        Optional(
                            fragment54),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowTableExtents = Command("ShowTableExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("tables"),
                        Token("("),
                        OneOrMoreCommaList(
                            Custom(
                                rules.TableNameReference,
                                shape29),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("where"),
                        Required(
                            OneOrMoreList(
                                fragment50,
                                separatorParser: Token("and")),
                            missing63),
                        Optional(
                            fragment51)}
                    ,
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowTableExtents2 = Command("ShowTableExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("tables"),
                        Token("("),
                        OneOrMoreCommaList(
                            Custom(
                                rules.TableNameReference,
                                shape29),
                            fnMissingElement: rules.MissingNameReference),
                        Token(")"),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowTableExtents3 = Command("ShowTableExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var TablesShardGroupsStatisticsShow = Command("TablesShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("("),
                    OneOrMoreCommaList(
                        Custom(
                            rules.TableNameReference,
                            shape29),
                        fnMissingElement: rules.MissingNameReference),
                    Token(")"),
                    Token("shard-groups").Hide(),
                    RequiredToken("statistics").Hide(),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD(), CD(), CD()}));

            var ShowTables = Command("ShowTables", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    RequiredToken("("),
                    Required(
                        OneOrMoreCommaList(
                            Custom(
                                rules.TableNameReference,
                                shape29),
                            fnMissingElement: rules.MissingNameReference),
                        missing33),
                    RequiredToken(")"),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.Table), CD()}));

            var ShowTablesColumnStatistics = Command("ShowTablesColumnStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("column"),
                    RequiredToken("statistics"),
                    RequiredToken("older"),
                    Required(rules.Value, rules.MissingValue),
                    new [] {CD(), CD(), CD(), CD(), CD(), CD("outdatewindow", CompletionHint.Literal)}));

            var ShowTablesDetails2 = Command("ShowTablesDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("details")));

            var TablesShardGroupsStatisticsShow2 = Command("TablesShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables"),
                    Token("shard-groups").Hide(),
                    RequiredToken("statistics").Hide()));

            var ShowTables2 = Command("ShowTables", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tables")));

            var ShowTableOperationsMirroringStatus = Command("ShowTableOperationsMirroringStatus", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("operations"),
                    RequiredToken("mirroring-status"),
                    new [] {CD(), CD(), CD("TableName"), CD(), CD()}));

            var ShowTableStarPolicyCaching = Command("ShowTableStarPolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("caching")));

            var ShowTableStarPolicyExtentTagsRetention = Command("ShowTableStarPolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("extent_tags_retention")));

            var ShowTableStarPolicyIngestionBatching = Command("ShowTableStarPolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("ingestionbatching")));

            var ShowTableStarPolicyIngestionTime = Command("ShowTableStarPolicyIngestionTime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("ingestiontime")));

            var ShowTableStarPolicyMerge = Command("ShowTableStarPolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("merge")));

            var ShowTableStarPolicyMirroring = Command("ShowTableStarPolicyMirroring", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("mirroring")));

            var ShowTableStarPolicyPartitioning = Command("ShowTableStarPolicyPartitioning", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("partitioning")));

            var ShowTableStarPolicyRestrictedViewAccess = Command("ShowTableStarPolicyRestrictedViewAccess", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("restricted_view_access")));

            var ShowTableStarPolicyRetention = Command("ShowTableStarPolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("retention")));

            var ShowTableStarPolicyRowLevelSecurity = Command("ShowTableStarPolicyRowLevelSecurity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("row_level_security")));

            var ShowTableStarPolicyRowOrder = Command("ShowTableStarPolicyRowOrder", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("roworder")));

            var ShowTableStarPolicySharding = Command("ShowTableStarPolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    Token("policy"),
                    Token("sharding")));

            var ShowTableStarPolicyUpdate = Command("ShowTableStarPolicyUpdate", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Token("*"),
                    RequiredToken("policy"),
                    RequiredToken("update")));

            var ShowTablePolicyAutoDelete = Command("ShowTablePolicyAutoDelete", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("auto_delete"),
                    shape197));

            var ShowTablePolicyCaching = Command("ShowTablePolicyCaching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("caching"),
                    shape197));

            var ShowTablePolicyEncoding = Command("ShowTablePolicyEncoding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("encoding"),
                    shape197));

            var ShowTablePolicyExtentTagsRetention = Command("ShowTablePolicyExtentTagsRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("extent_tags_retention"),
                    shape197));

            var ShowTablePolicyIngestionBatching = Command("ShowTablePolicyIngestionBatching", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("ingestionbatching"),
                    shape197));

            var ShowTablePolicyMerge = Command("ShowTablePolicyMerge", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("merge"),
                    shape197));

            var ShowTablePolicyMirroring = Command("ShowTablePolicyMirroring", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("mirroring"),
                    shape197));

            var ShowTablePolicyPartitioning = Command("ShowTablePolicyPartitioning", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("partitioning"),
                    shape197));

            var ShowTablePolicyRestrictedViewAccess = Command("ShowTablePolicyRestrictedViewAccess", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("restricted_view_access"),
                    shape197));

            var ShowTablePolicyRetention = Command("ShowTablePolicyRetention", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("retention"),
                    shape197));

            var ShowTablePolicyRowOrder = Command("ShowTablePolicyRowOrder", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("roworder"),
                    shape197));

            var ShowTablePolicySharding = Command("ShowTablePolicySharding", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("sharding"),
                    shape197));

            var ShowTablePolicyStreamingIngestion = Command("ShowTablePolicyStreamingIngestion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    Token("streamingingestion"),
                    shape197));

            var ShowTablePolicyUpdate = Command("ShowTablePolicyUpdate", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("policy"),
                    RequiredToken("update"),
                    shape197));

            var ShowTableRowStoreReferences = Command("ShowTableRowStoreReferences", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("rowstore_references"),
                    shape225));

            var ShowTableRowStoreSealInfo = Command("ShowTableRowStoreSealInfo", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    Token("rowstore_sealinfo"),
                    shape282));

            var ShowTableRowStores = Command("ShowTableRowStores", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.DatabaseTableNameReference),
                    RequiredToken("rowstores"),
                    shape282));

            var ShowTableColumnsClassification = Command("ShowTableColumnsClassification", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("columns"),
                    RequiredToken("classification"),
                    shape197));

            var ShowTableColumnStatitics = Command("ShowTableColumnStatitics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("column"),
                    RequiredToken("statistics"),
                    shape197));

            var ShowTableCslSchema = Command("ShowTableCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("cslschema"),
                    shape225));

            var ShowTableDataStatistics = Command("ShowTableDataStatistics", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("data"),
                    RequiredToken("statistics"),
                    Optional(
                        Custom(
                            Token("with"),
                            RequiredToken("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        First(
                                            Token("from"),
                                            Token("samplepercent"),
                                            Token("scope"),
                                            Token("to"),
                                            If(Not(And(Token("from", "samplepercent", "scope", "to"))), rules.NameDeclaration)),
                                        RequiredToken("="),
                                        Required(rules.Value, rules.MissingValue),
                                        shape129)),
                                missing70),
                            RequiredToken(")"))),
                    shape283));

            var ShowTableDetails = Command("ShowTableDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("details"),
                    shape225));

            var ShowTableDimensions = Command("ShowTableDimensions", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("dimensions"),
                    shape225));

            var ShowExtentCorruptedDatetime2 = Command("ShowExtentCorruptedDatetime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("extents"),
                    Required(
                        fragment65,
                        missing71).Hide(),
                    new [] {CD(), CD(), CD(CompletionHint.Table), CD(), CD()}));

            var ShowTableExtentsMetadata2 = Command("ShowTableExtentsMetadata", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("extents"),
                    Optional(
                        fragment53),
                    Optional(Token("hot")),
                    Token("metadata"),
                    Optional(
                        fragment54),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowTableExtents4 = Command("ShowTableExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    RequiredToken("where"),
                    Required(
                        OneOrMoreList(
                            fragment50,
                            separatorParser: Token("and")),
                        missing63),
                    Optional(
                        fragment51),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(isOptional: true)}));

            var ShowTableExtents5 = Command("ShowTableExtents", 
                Custom(
                    new Parser<LexicalToken>[] {
                        Token("show", CompletionKind.CommandPrefix),
                        Token("table"),
                        If(Not(Token("*")), rules.TableNameReference),
                        Token("extents"),
                        Optional(
                            fragment52),
                        Optional(Token("hot")),
                        RequiredToken("with"),
                        RequiredToken("("),
                        RequiredToken("extentsShowFilteringRuntimePolicy"),
                        RequiredToken("="),
                        Required(rules.Value, rules.MissingValue),
                        RequiredToken(")")}
                    ,
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD(isOptional: true), CD(), CD(), CD(), CD(), CD("policy", CompletionHint.Literal), CD()}));

            var ShowTableExtents6 = Command("ShowTableExtents", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("extents"),
                    Optional(
                        fragment52),
                    Optional(Token("hot")),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD(isOptional: true)}));

            var ShowTableIngestionMappings = Command("ShowTableIngestionMappings", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("ingestion"),
                    Optional(
                        Custom(
                            Token("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                            shape46)),
                    Token("mappings"),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD()}));

            var ShowTableIngestionMapping = Command("ShowTableIngestionMapping", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("ingestion"),
                    Optional(
                        Custom(
                            Token("avro", "csv", "json", "orc", "parquet", "w3clogfile"),
                            shape46)),
                    RequiredToken("mapping"),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(isOptional: true), CD(), CD("MappingName", CompletionHint.Literal)}));

            var ShowTableCslSchema2 = Command("ShowTableCslSchema", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("kqlschema"),
                    shape225));

            var ShowTableOperationsMirroringExportedArtifacts = Command("ShowTableOperationsMirroringExportedArtifacts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("operations"),
                    Token("mirroring-exported-artifacts"),
                    shape197));

            var ShowTableOperationsMirroringFailures = Command("ShowTableOperationsMirroringFailures", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("operations"),
                    Token("mirroring-failures"),
                    shape197));

            var ShowTableOperationsMirroringStatus2 = Command("ShowTableOperationsMirroringStatus", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("operations"),
                    RequiredToken("mirroring-status"),
                    shape197));

            var ShowTablePolicyIngestionTime = Command("ShowTablePolicyIngestionTime", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("policy"),
                    Token("ingestiontime"),
                    shape197));

            var ShowTablePolicyRowLevelSecurity = Command("ShowTablePolicyRowLevelSecurity", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("policy"),
                    RequiredToken("row_level_security"),
                    shape197));

            var ShowTablePrincipals = Command("ShowTablePrincipals", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("principals"),
                    shape225));

            var ShowTablePrincipalRoles = Command("ShowTablePrincipalRoles", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("principal"),
                    Required(
                        First(
                            Token("roles"),
                            fragment59),
                        missing64),
                    Optional(
                        fragment7),
                    shape283));

            var ShowTableSchemaAsJson = Command("ShowTableSchemaAsJson", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("schema"),
                    RequiredToken("as"),
                    RequiredToken("json"),
                    shape135));

            var TableShardGroupsStatisticsShow = Command("TableShardGroupsStatisticsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("shard-groups").Hide(),
                    Token("statistics").Hide(),
                    shape197));

            var TableShardGroupsShow = Command("TableShardGroupsShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("shard-groups").Hide(),
                    shape225));

            var TableShardsGroupMetadataShow = Command("TableShardsGroupMetadataShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("shards-group").Hide(),
                    rules.AnyGuidLiteralOrString,
                    Token("shards").Hide(),
                    Token("metadata").Hide(),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("ShardsGroupId", CompletionHint.Literal), CD(), CD()}));

            var TableShardsGroupShow = Command("TableShardsGroupShow", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    If(Not(Token("*")), rules.TableNameReference),
                    Token("shards-group").Hide(),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    RequiredToken("shards").Hide(),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("ShardsGroupId", CompletionHint.Literal), CD()}));

            var ShowTable = Command("ShowTable", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("table"),
                    Required(If(Not(Token("*")), rules.TableNameReference), rules.MissingNameReference),
                    shape285));

            var ShowTcpConnections = Command("ShowTcpConnections", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tcpconnections")));

            var ShowTcpPorts = Command("ShowTcpPorts", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("tcpports")));

            var ShowThreadPools = Command("ShowThreadPools", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("threadpools")));

            var ShowVersion = Command("ShowVersion", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("version")));

            var ShowWorkloadGroups = Command("ShowWorkloadGroups", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("workload_groups")));

            var ShowWorkloadGroup = Command("ShowWorkloadGroup", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Token("workload_group"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    new [] {CD(), CD(), CD("WorkloadGroup", CompletionHint.None)}));

            var ShowExtentDetails = Command("ShowExtentDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Required(If(Not(And(Token("basicauth", "cache", "callstacks", "capacity", "certificates", "cloudsettings", "cluster", "column", "commands-and-queries", "commands", "commconcurrency", "commpools", "continuous-exports", "continuous-export", "databases", "database", "data", "diagnostics", "entity_groups", "entity_group", "entity", "extentcontainers", "extents", "external", "fabriccache", "fabricclocks", "fabriclocks", "fabric", "featureflags", "follower", "freshness", "functions", "function", "ingestion", "journal", "materialized-views", "materialized-view", "memory", "mempools", "operations", "operation", "plugins", "principal", "queries", "queryexecution", "queryplan", "query", "request_support", "rowstores", "rowstore", "running", "schema", "servicepoints", "stored_query_results", "stored_query_result", "streamingingestion", "tables", "table", "tcpconnections", "tcpports", "threadpools", "version", "workload_groups", "workload_group"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    RequiredToken("extent"),
                    RequiredToken("details"),
                    Optional(
                        Custom(
                            rules.AnyGuidLiteralOrString,
                            shape286)),
                    Optional(
                        fragment5),
                    new [] {CD(), CD("tableName", CompletionHint.None), CD(), CD(), CD(CompletionHint.Literal, isOptional: true), CD(isOptional: true)}));

            var ShowExtentDetails2 = Command("ShowExtentDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Required(If(Not(And(Token("basicauth", "cache", "callstacks", "capacity", "certificates", "cloudsettings", "cluster", "column", "commands-and-queries", "commands", "commconcurrency", "commpools", "continuous-exports", "continuous-export", "databases", "database", "data", "diagnostics", "entity_groups", "entity_group", "entity", "extentcontainers", "extents", "external", "fabriccache", "fabricclocks", "fabriclocks", "fabric", "featureflags", "follower", "freshness", "functions", "function", "ingestion", "journal", "materialized-views", "materialized-view", "memory", "mempools", "operations", "operation", "plugins", "principal", "queries", "queryexecution", "queryplan", "query", "request_support", "rowstores", "rowstore", "running", "schema", "servicepoints", "stored_query_results", "stored_query_result", "streamingingestion", "tables", "table", "tcpconnections", "tcpports", "threadpools", "version", "workload_groups", "workload_group"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    RequiredToken("extent"),
                    RequiredToken("with"),
                    RequiredToken("("),
                    ZeroOrMoreCommaList(
                        fragment0),
                    RequiredToken(")"),
                    new [] {CD(), CD("tableName", CompletionHint.None), CD(), CD(), CD(), CD(CompletionHint.None), CD()}));

            var ShowExtentColumnStorageStats = Command("ShowExtentColumnStorageStats", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    If(Not(And(Token("basicauth", "cache", "callstacks", "capacity", "certificates", "cloudsettings", "cluster", "column", "commands-and-queries", "commands", "commconcurrency", "commpools", "continuous-exports", "continuous-export", "databases", "database", "data", "diagnostics", "entity_groups", "entity_group", "entity", "extentcontainers", "extents", "external", "fabriccache", "fabricclocks", "fabriclocks", "fabric", "featureflags", "follower", "freshness", "functions", "function", "ingestion", "journal", "materialized-views", "materialized-view", "memory", "mempools", "operations", "operation", "plugins", "principal", "queries", "queryexecution", "queryplan", "query", "request_support", "rowstores", "rowstore", "running", "schema", "servicepoints", "stored_query_results", "stored_query_result", "streamingingestion", "tables", "table", "tcpconnections", "tcpports", "threadpools", "version", "workload_groups", "workload_group"))), rules.NameDeclaration),
                    Token("extent"),
                    rules.AnyGuidLiteralOrString,
                    Token("column"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("storage"),
                    RequiredToken("stats"),
                    new [] {CD(), CD("tableName", CompletionHint.None), CD(), CD("extentId", CompletionHint.Literal), CD(), CD("columnName", CompletionHint.None), CD(), CD()}));

            var ShowExtentDetails3 = Command("ShowExtentDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Required(If(Not(And(Token("basicauth", "cache", "callstacks", "capacity", "certificates", "cloudsettings", "cluster", "column", "commands-and-queries", "commands", "commconcurrency", "commpools", "continuous-exports", "continuous-export", "databases", "database", "data", "diagnostics", "entity_groups", "entity_group", "entity", "extentcontainers", "extents", "external", "fabriccache", "fabricclocks", "fabriclocks", "fabric", "featureflags", "follower", "freshness", "functions", "function", "ingestion", "journal", "materialized-views", "materialized-view", "memory", "mempools", "operations", "operation", "plugins", "principal", "queries", "queryexecution", "queryplan", "query", "request_support", "rowstores", "rowstore", "running", "schema", "servicepoints", "stored_query_results", "stored_query_result", "streamingingestion", "tables", "table", "tcpconnections", "tcpports", "threadpools", "version", "workload_groups", "workload_group"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    RequiredToken("extent"),
                    Required(rules.AnyGuidLiteralOrString, rules.MissingValue),
                    Optional(
                        fragment5),
                    new [] {CD(), CD("tableName", CompletionHint.None), CD(), CD("eid", CompletionHint.Literal), CD(isOptional: true)}));

            var ShowExtentDetails4 = Command("ShowExtentDetails", 
                Custom(
                    Token("show", CompletionKind.CommandPrefix),
                    Required(If(Not(And(Token("basicauth", "cache", "callstacks", "capacity", "certificates", "cloudsettings", "cluster", "column", "commands-and-queries", "commands", "commconcurrency", "commpools", "continuous-exports", "continuous-export", "databases", "database", "data", "diagnostics", "entity_groups", "entity_group", "entity", "extentcontainers", "extents", "external", "fabriccache", "fabricclocks", "fabriclocks", "fabric", "featureflags", "follower", "freshness", "functions", "function", "ingestion", "journal", "materialized-views", "materialized-view", "memory", "mempools", "operations", "operation", "plugins", "principal", "queries", "queryexecution", "queryplan", "query", "request_support", "rowstores", "rowstore", "running", "schema", "servicepoints", "stored_query_results", "stored_query_result", "streamingingestion", "tables", "table", "tcpconnections", "tcpports", "threadpools", "version", "workload_groups", "workload_group"))), rules.NameDeclaration), rules.MissingNameDeclaration),
                    RequiredToken("extent"),
                    new [] {CD(), CD("tableName", CompletionHint.None), CD()}));

            var TableShuffleExtents = Command("TableShuffleExtents", 
                Custom(
                    Token("shuffle", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    Token("table"),
                    rules.TableNameReference,
                    Token("extents"),
                    First(
                        Custom(
                            Token("("),
                            OneOrMoreCommaList(
                                Custom(
                                    rules.AnyGuidLiteralOrString,
                                    shape230),
                                fnMissingElement: rules.MissingValue),
                            Token(")"),
                            shape38),
                        Custom(
                            Token("("),
                            Required(
                                OneOrMoreCommaList(
                                    Custom(
                                        rules.AnyGuidLiteralOrString,
                                        shape230),
                                    fnMissingElement: rules.MissingValue),
                                missing54),
                            RequiredToken(")"),
                            shape38),
                        Token("all")),
                    Optional(
                        fragment5),
                    new [] {CD(), CD(isOptional: true), CD(), CD("TableName", CompletionHint.Table), CD(), CD(), CD(isOptional: true)}));

            var TableShuffleExtentsQuery = Command("TableShuffleExtentsQuery", 
                Custom(
                    Token("shuffle", CompletionKind.CommandPrefix),
                    Optional(Token("async")),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("extents"),
                    Optional(
                        fragment5),
                    RequiredToken("<|"),
                    Required(rules.QueryInput, rules.MissingExpression),
                    new [] {CD(), CD(isOptional: true), CD(), CD("tableName", CompletionHint.Table), CD(), CD(isOptional: true), CD(), CD("Query", CompletionHint.Tabular)}));

            var UndoDropTable = Command("UndoDropTable", 
                Custom(
                    Token("undo", CompletionKind.CommandPrefix),
                    RequiredToken("drop"),
                    RequiredToken("table"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Optional(
                        Custom(
                            Token("as"),
                            Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                            new [] {CD(), CD("TableName", CompletionHint.None)})),
                    RequiredToken("version"),
                    RequiredToken("="),
                    Required(rules.StringLiteral, rules.MissingStringLiteral),
                    Optional(Token("internal")),
                    new [] {CD(), CD(), CD(), CD(CompletionHint.None), CD(isOptional: true), CD(), CD(), CD("Version", CompletionHint.Literal), CD(isOptional: true)}));

            var TableDataUpdate = Command("TableDataUpdate", 
                Custom(
                    Token("update", CompletionKind.CommandPrefix),
                    Token("table"),
                    rules.TableNameReference,
                    Token("delete"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    RequiredToken("append"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD("DeleteIdentifier", CompletionHint.None), CD(), CD("AppendIdentifier", CompletionHint.None), CD("csl")}));

            var TableDataUpdateShortSyntax = Command("TableDataUpdateShortSyntax", 
                Custom(
                    Token("update", CompletionKind.CommandPrefix),
                    RequiredToken("table"),
                    Required(rules.TableNameReference, rules.MissingNameReference),
                    RequiredToken("on"),
                    Required(rules.NameDeclaration, rules.MissingNameDeclaration),
                    Required(
                        fragment6,
                        missing1),
                    new [] {CD(), CD(), CD("TableName", CompletionHint.Table), CD(), CD(CompletionHint.None), CD("csl")}));

            var commandParsers = new Parser<LexicalToken, Command>[]
            {
                AddClusterRole,
                AddClusterRole2,
                AddClusterRole3,
                AddClusterRole4,
                AddClusterBlockedPrincipals,
                AddClusterRole5,
                AddClusterRole6,
                AddClusterRole7,
                AddClusterRole8,
                AddClusterRole9,
                AddDatabaseRole,
                AddExternalTableAdmins,
                AddFollowerDatabaseAuthorizedPrincipals,
                AddFunctionRole,
                AddMaterializedViewAdmins,
                AddTableRole,
                AlterMergeExtentTagsFromQuery,
                AlterMergeClusterPolicyCallout,
                AlterMergeClusterPolicyCapacity,
                AlterMergeClusterPolicyDiagnostics,
                AlterMergeClusterPolicyIngestionBatching,
                AlterMergeClusterPolicyManagedIdentity,
                AlterMergeClusterPolicyMultiDatabaseAdmins,
                AlterMergeClusterPolicyQueryWeakConsistency,
                AlterMergeClusterPolicyRequestClassification,
                AlterMergeClusterPolicyRowStore,
                AlterMergeClusterPolicySharding,
                AlterMergeClusterPolicyStreamingIngestion,
                AlterMergeColumnPolicyEncoding,
                AlterMergeDatabaseIngestionMapping,
                AlterMergeDatabasePolicyDiagnostics,
                AlterMergeDatabasePolicyEncoding,
                AlterMergeDatabasePolicyIngestionBatching,
                AlterMergeDatabasePolicyManagedIdentity,
                AlterMergeDatabasePolicyMerge,
                AlterMergeDatabasePolicyMirroring,
                AlterMergeDatabasePolicyMirroringWithJson,
                AlterMergeDatabasePolicyRetention,
                AlterMergeDatabasePolicySharding,
                AlterMergeDatabasePolicyShardsGrouping,
                AlterMergeDatabasePolicyStreamingIngestion,
                AlterMergeDatabaseTableMirroringPolicyTemplates,
                AlterMergeEntityGroup,
                AlterMergeMaterializedViewPolicyMerge,
                AlterMergeMaterializedViewPolicyPartitioning,
                AlterMergeMaterializedViewPolicyRetention,
                AlterMergeTablePolicyEncoding,
                AlterMergeTablePolicyIngestionBatching,
                AlterMergeTablePolicyMerge,
                AlterMergeTablePolicyMirroring,
                AlterMergeTablePolicyPartitioning,
                AlterMergeTablePolicyRetention,
                AlterMergeTablePolicyRowOrder,
                AlterMergeTablePolicySharding,
                AlterMergeTablePolicyStreamingIngestion,
                AlterMergeTablePolicyUpdate,
                AlterMergeTable,
                AlterMergeTableColumnDocStrings,
                AlterMergeExtentTagsFromQuery2,
                AlterMergeTableIngestionMapping,
                AlterMergeTablePolicyMirroringWithJson,
                AlterMergeWorkloadGroup,
                AlterClusterStorageKeys,
                AlterDatabaseStorageKeys,
                AlterExtentTagsFromQuery,
                AlterCache,
                AlterClusterPolicyCaching,
                AlterClusterPolicyCallout,
                AlterClusterPolicyCapacity,
                AlterClusterPolicyDiagnostics,
                AlterClusterPolicyIngestionBatching,
                AlterClusterPolicyManagedIdentity,
                AlterClusterPolicyMultiDatabaseAdmins,
                AlterClusterPolicyQueryWeakConsistency,
                AlterClusterPolicyRequestClassification,
                AlterClusterPolicyRowStore,
                AlterClusterPolicySandbox,
                AlterClusterPolicySharding,
                AlterClusterPolicyStreamingIngestion,
                AlterClusterStorageKeys2,
                AlterColumnsPolicyEncodingByQuery,
                AlterColumnPolicyCaching,
                AlterColumnPolicyEncodingType,
                AlterColumnPolicyEncoding,
                AlterColumnType,
                AlterDatabaseIngestionMapping,
                AlterDatabasePersistMetadata,
                AlterDatabasePolicyCaching,
                AlterDatabasePolicyDiagnostics,
                AlterDatabasePolicyEncoding,
                AlterDatabasePolicyExtentTagsRetention,
                AlterDatabasePolicyIngestionBatching,
                AlterDatabasePolicyManagedIdentity,
                AlterDatabasePolicyMerge,
                AlterDatabasePolicyMirroring,
                AlterDatabasePolicyMirroringWithJson,
                AlterDatabasePolicyRetention,
                AlterDatabasePolicySharding,
                AlterDatabasePolicyShardsGrouping,
                AlterDatabasePolicyStreamingIngestion,
                AlterDatabaseTableMirroringPolicyTemplates,
                AlterDatabasePrettyName,
                AlterDatabaseStorageKeys2,
                AlterEntityGroup,
                AlterExtentContainersAdd,
                AlterExtentContainersDrop,
                AlterExtentContainersRecycle,
                AlterExtentContainersSet,
                AlterStorageExternalTable,
                AlterStorageExternalTable2,
                AlterStorageExternalTable3,
                AlterSqlExternalTable,
                AlterStorageExternalTable4,
                AlterExternalTableDocString,
                AlterExternalTableFolder,
                AlterStorageExternalTable5,
                AlterExternalTableMapping,
                AlterFabricServiceAssignmentsCommand,
                AlterFollowerClusterConfiguration,
                AlterFollowerDatabaseConfiguration,
                AlterFollowerDatabaseConfiguration2,
                AlterFollowerDatabaseChildEntities,
                AlterFollowerTablesPolicyCaching,
                AlterFollowerDatabaseChildEntities2,
                AlterFollowerDatabaseChildEntities3,
                AlterFollowerTablesPolicyCaching2,
                AlterFollowerDatabaseConfiguration3,
                AlterFollowerDatabaseAuthorizedPrincipals,
                AlterFollowerDatabaseConfiguration4,
                AlterFollowerDatabaseConfiguration5,
                AlterFollowerTablesPolicyCaching3,
                AlterFollowerDatabaseChildEntities4,
                AlterFollowerDatabaseChildEntities5,
                AlterFollowerTablesPolicyCaching4,
                AlterFunction,
                AlterFunctionDocString,
                AlterFunctionFolder,
                AlterFunction2,
                AlterMaterializedViewOverMaterializedView,
                AlterMaterializedView,
                AlterMaterializedViewAutoUpdateSchema,
                AlterMaterializedViewDocString,
                AlterMaterializedViewFolder,
                AlterMaterializedViewLookback,
                AlterMaterializedViewOverMaterializedView2,
                AlterMaterializedView2,
                AlterMaterializedViewPolicyCaching,
                AlterMaterializedViewPolicyPartitioning,
                AlterMaterializedViewPolicyRetention,
                AlterMaterializedViewPolicyRowLevelSecurity,
                AlterPoliciesOfRetention,
                AlterTablesPolicyCaching,
                AlterTablesPolicyIngestionBatching,
                AlterTablesPolicyIngestionTime,
                AlterTablesPolicyMerge,
                AlterTablesPolicyRestrictedViewAccess,
                AlterTablesPolicyRetention,
                AlterTablesPolicyRowOrder,
                AlterTableColumnStatisticsMethod,
                AlterTablePolicyAutoDelete,
                AlterTablePolicyCaching,
                AlterTablePolicyEncoding,
                AlterTablePolicyExtentTagsRetention,
                AlterTablePolicyIngestionBatching,
                AlterTablePolicyMerge,
                AlterTablePolicyMirroring,
                AlterTablePolicyPartitioning,
                AlterTablePolicyRestrictedViewAccess,
                AlterTablePolicyRetention,
                AlterTablePolicyRowOrder,
                AlterTablePolicySharding,
                AlterTablePolicyStreamingIngestion,
                AlterTablePolicyUpdate,
                AlterTableRowStoreReferencesDisableBlockedKeys,
                AlterTableRowStoreReferencesDisableKey,
                AlterTableRowStoreReferencesDisableRowStore,
                AlterTableRowStoreReferencesDropBlockedKeys,
                AlterTableRowStoreReferencesDropKey,
                AlterTableRowStoreReferencesDropRowStore,
                AlterTable,
                AlterTableColumnDocStrings,
                AlterTableColumnsPolicyEncoding,
                AlterTableColumnStatistics,
                AlterTableDocString,
                AlterExtentTagsFromQuery2,
                AlterTableFolder,
                AlterTableIngestionMapping,
                AlterTablePolicyIngestionTime,
                AlterTablePolicyMirroringWithJson,
                AlterTablePolicyRowLevelSecurity,
                AppendTable,
                ApplyTableMirroringPolicyTemplateToTables,
                AttachExtentsIntoTableByMetadata,
                AttachDatabaseMetadata,
                AttachDatabase,
                AttachExtentsIntoTableByMetadata2,
                AttachExtentsIntoTableByContainer,
                AttachExtentsIntoTableByMetadata3,
                CancelOperation,
                CancelQuery,
                CleanDatabaseExtentContainers,
                ClearTableData,
                ClearRemoteClusterDatabaseSchema,
                ClearClusterCredStoreCache,
                ClearExternalArtifactsCache,
                ClearClusterGroupMembershipCache,
                ClearDatabaseCacheQueryResults,
                ClearDatabaseCacheQueryWeakConsistency,
                ClearDatabaseCacheStreamingIngestionSchema,
                ClearMaterializedViewData,
                ClearMaterializedViewStatistics,
                ClearTableCacheStreamingIngestionSchema,
                ClearTableData2,
                CreateMergeTables,
                CreateMergeTable,
                CreateOrAlterContinuousExport,
                CreateOrAlterDatabaseIngestionMapping,
                CreateOrAlterEntityGroupCommand,
                CreateOrAlterStorageExternalTable,
                CreateOrAlterStorageExternalTable2,
                CreateOrAlterStorageExternalTable3,
                CreateOrAlterSqlExternalTable,
                CreateOrAlterStorageExternalTable4,
                CreateOrAlterStorageExternalTable5,
                CreateOrAlterFunction,
                CreateOrAlterMaterializedViewOverMaterializedView,
                CreateOrAlterMaterializedView,
                CreateOrAlterTableIngestionMapping,
                CreateOrAleterWorkloadGroup,
                CreateMaterializedViewOverMaterializedView,
                CreateMaterializedView,
                CreateBasicAuthUser,
                CreateDatabaseIngestionMapping,
                CreateDatabasePersist,
                CreateDatabaseVolatile,
                CreateEntityGroupCommand,
                CreateStorageExternalTable,
                CreateStorageExternalTable2,
                CreateStorageExternalTable3,
                CreateSqlExternalTable,
                CreateStorageExternalTable4,
                CreateStorageExternalTable5,
                CreateExternalTableMapping,
                CreateFunction,
                CreateMaterializedViewOverMaterializedView2,
                CreateMaterializedView2,
                CreateMaterializedViewOverMaterializedView3,
                CreateMaterializedView3,
                CreateRequestSupport,
                CreateRowStore,
                CreateTables,
                CreateTable,
                CreateTableBasedOnAnother,
                CreateTableIngestionMapping,
                CreateTempStorage,
                DefineTables,
                DefineTable,
                DeleteMaterializedViewRecords,
                DeleteTableRecords,
                DeleteClusterPolicyCaching,
                DeleteClusterPolicyCallout,
                DeleteClusterPolicyManagedIdentity,
                DeleteClusterPolicyRequestClassification,
                DeleteClusterPolicyRowStore,
                DeleteClusterPolicySandbox,
                DeleteClusterPolicySharding,
                DeleteClusterPolicyStreamingIngestion,
                DeleteColumnPolicyCaching,
                DeleteColumnPolicyEncoding,
                DeleteDatabasePolicyCaching,
                DeleteDatabasePolicyDiagnostics,
                DeleteDatabasePolicyEncoding,
                DeleteDatabasePolicyExtentTagsRetention,
                DeleteDatabasePolicyIngestionBatching,
                DeleteDatabasePolicyManagedIdentity,
                DeleteDatabasePolicyMerge,
                DeleteDatabasePolicyMirroring,
                DeleteDatabasePolicyRetention,
                DeleteDatabasePolicySharding,
                DeleteDatabasePolicyShardsGrouping,
                DeleteDatabasePolicyStreamingIngestion,
                DropDatabaseTableMirroringPolicyTemplates,
                DropFollowerTablesPolicyCaching,
                DropFollowerTablesPolicyCaching2,
                DropFollowerDatabasePolicyCaching,
                DropFollowerTablesPolicyCaching3,
                DropFollowerTablesPolicyCaching4,
                DeleteMaterializedViewPolicyCaching,
                DeleteMaterializedViewPolicyPartitioning,
                DeleteMaterializedViewPolicyRowLevelSecurity,
                DeleteMaterializedViewRecords2,
                DeletePoliciesOfRetention,
                DeleteTablePolicyAutoDelete,
                DeleteTablePolicyCaching,
                DeleteTablePolicyEncoding,
                DeleteTablePolicyExtentTagsRetention,
                DeleteTablePolicyIngestionBatching,
                DeleteTablePolicyMerge,
                DeleteTablePolicyMirroring,
                DeleteTablePolicyPartitioning,
                DeleteTablePolicyRestrictedViewAccess,
                DeleteTablePolicyRetention,
                DeleteTablePolicyRowOrder,
                DeleteTablePolicySharding,
                DeleteTablePolicyStreamingIngestion,
                DeleteTablePolicyUpdate,
                DeleteTablePolicyIngestionTime,
                DeleteTablePolicyRowLevelSecurity,
                DeleteTableRecords2,
                DetachDatabase,
                DropRowStore,
                DisableContinuousExport,
                DisableDatabaseStreamingIngestionMaintenanceMode,
                DisableDatabaseMaintenanceMode,
                EnableDisableMaterializedView,
                DisablePlugin,
                DropPretendExtentsByProperties,
                DropEmptyExtentContainers,
                DropExtentTagsFromTable,
                DropExtentTagsFromQuery,
                DropExtentTagsFromQuery2,
                DropBasicAuthUser,
                DropClusterRole,
                DropClusterRole2,
                DropClusterRole3,
                DropClusterRole4,
                DropClusterBlockedPrincipals,
                DropClusterRole5,
                DropClusterRole6,
                DropClusterRole7,
                DropClusterRole8,
                DropClusterRole9,
                DropColumn,
                DropContinuousExport,
                DropDatabaseRole,
                DropDatabaseIngestionMapping,
                DropDatabaseRole2,
                DropDatabaseRole3,
                DropDatabasePrettyName,
                DropDatabaseRole4,
                DropDatabaseRole5,
                DropDatabaseRole6,
                DropEmptyExtentContainers2,
                DropEntityGroup,
                DropExtents,
                DropExtents2,
                DropExtents3,
                DropExtents4,
                DropExtentsPartitionMetadata,
                DropExtents5,
                DropExtentTagsRetention,
                DropExtent,
                DropExternalTableAdmins,
                DropExternalTableMapping,
                DropExternalTable,
                DropFabricServiceAssignmentsCommand,
                DropFollowerDatabases,
                DropFollowerDatabases2,
                DropFollowerDatabaseAuthorizedPrincipals,
                DropFunctions,
                DropFunctionRole,
                DropFunction,
                DropFunction2,
                DropMaterializedViewAdmins,
                DropMaterializedView,
                DropRowStore2,
                StoredQueryResultsDrop,
                StoredQueryResultDrop,
                DropStoredQueryResultContainers,
                DropTables,
                DropTableRole,
                DropTableColumns,
                DropExtentTagsFromTable2,
                DropExtentTagsFromQuery3,
                DropExtentTagsFromQuery4,
                DropTable,
                DropTableIngestionMapping,
                DropTableRole2,
                DropTable2,
                DropTempStorage,
                DropUnusedStoredQueryResultContainers,
                DropWorkloadGroup,
                EnableContinuousExport,
                EnableDatabaseStreamingIngestionMaintenanceMode,
                EnableDatabaseMaintenanceMode,
                EnableDisableMaterializedView2,
                EnablePlugin,
                ExecuteClusterScript,
                ExecuteDatabaseScript,
                ExecuteDatabaseScript2,
                ExportToStorage,
                ExportToStorage2,
                ExportToStorage3,
                ExportToStorage4,
                ExportToSqlTable,
                ExportToExternalTable,
                ExportToStorage5,
                IngestIntoTable,
                IngestInlineIntoTable,
                IngestIntoTable2,
                MergeExtents,
                MergeDatabaseShardGroups,
                MergeExtentsDryrun,
                MergeExtents2,
                MoveExtentsFrom,
                MoveExtentsFrom2,
                MoveExtentsQuery,
                PatchExtentCorruptedDatetime,
                RenameColumns,
                RenameColumn,
                RenameMaterializedView,
                RenameTables,
                RenameTable,
                ReplaceExtents,
                ReplaceDatabaseKeyVaultSecrets,
                ReplaceExtents2,
                SetOrAppendTable,
                StoredQueryResultSetOrReplace,
                SetOrReplaceTable,
                SetAccess,
                StoredQueryResultSet,
                SetTable,
                SetClusterRole,
                SetContinuousExportCursor,
                SetDatabaseRole,
                SetExternalTableAdmins,
                SetFunctionRole,
                SetMaterializedViewAdmins,
                SetMaterializedViewConcurrency,
                SetMaterializedViewCursor,
                StoredQueryResultSet2,
                SetTableRowStoreReferences,
                SetTableRole,
                SetTable2,
                ShowBasicAuthUsers,
                ShowCache,
                ShowCallStacks,
                ShowCapacity,
                ShowCertificates,
                ShowCloudSettings,
                ShowClusterAdminState,
                ShowClusterBlockedPrincipals,
                ShowClusterDatabases,
                ShowClusterDatabasesDataStats,
                ShowClusterDatabasesDetails,
                ShowClusterDatabasesIdentity,
                ShowClusterDatabasesPolicies,
                ShowClusterDatabases2,
                ShowClusterDetails,
                ShowClusterExtentsMetadata,
                ShowClusterExtents,
                ShowClusterExtents2,
                ShowClusterExtents3,
                ShowIngestionMappings,
                ShowClusterJournal,
                ShowClusterMonitoring,
                ShowClusterNetwork,
                ShowClusterPendingContinuousExports,
                ShowClusterPolicyCaching,
                ShowClusterPolicyCallout,
                ShowClusterPolicyCapacity,
                ShowClusterPolicyDiagnostics,
                ShowClusterPolicyIngestionBatching,
                ShowClusterPolicyManagedIdentity,
                ShowClusterPolicyMultiDatabaseAdmins,
                ShowClusterPolicyQueryWeakConsistency,
                ShowClusterPolicyRequestClassification,
                ShowClusterPolicyRowStore,
                ShowClusterPolicySandbox,
                ShowClusterPolicySharding,
                ShowClusterPolicyStreamingIngestion,
                ShowClusterPrincipals,
                ShowClusterPrincipalRoles,
                ShowClusterSandboxesStats,
                ShowClusterScaleIn,
                ShowSchema,
                ShowClusterServices,
                ShowClusterStorageKeysHash,
                ShowCluster,
                ShowColumnPolicyCaching,
                ShowColumnPolicyCaching2,
                ShowColumnPolicyEncoding,
                ShowCommandsAndQueries,
                ShowCommands,
                ShowCommConcurrency,
                ShowCommPools,
                ShowContinuousExports,
                ShowContinuousExportExportedArtifacts,
                ShowContinuousExportFailures,
                ShowContinuousExport,
                ShowClusterDatabases3,
                ShowDatabaseExtentsMetadata,
                ShowDatabaseExtents,
                ShowDatabaseExtents2,
                ShowDatabaseExtents3,
                ShowDatabasesSchemaAsJson,
                ShowDatabasesSchema,
                ShowDatabasesSchema2,
                ShowClusterDatabases4,
                ShowDatabaseExtentsMetadata2,
                ShowDatabaseExtents4,
                ShowDatabaseExtents5,
                ShowDatabaseExtents6,
                ShowDatabasesSchemaAsJson2,
                ShowDatabasesSchema3,
                ShowDatabasesSchema4,
                ShowClusterDatabases5,
                ShowDatabasesSchemaAsJson3,
                ShowDatabasesSchema5,
                ShowDatabasesSchema6,
                ShowClusterDatabasesDataStats2,
                ShowClusterDatabasesDetails2,
                ShowDatabasesEntities,
                ShowClusterDatabasesIdentity2,
                ShowDatabasesManagementGroups,
                ShowClusterDatabasesPolicies2,
                ShowClusterDatabases6,
                ShowDatabasePolicyCaching,
                ShowDatabasePolicyExtentTagsRetention,
                ShowDatabasePolicyIngestionBatching,
                ShowDatabasePolicyMerge,
                ShowDatabasePolicyRetention,
                ShowDatabasePolicySharding,
                ShowDatabasePolicyShardsGrouping,
                ShowDatabaseCacheQueryResults,
                ShowDatabaseCslSchema,
                ShowDatabaseDataStats,
                ShowDatabaseDetails,
                ShowDatabaseExtentsMetadata3,
                ShowDatabaseExtents7,
                ShowDatabaseExtents8,
                ShowDatabaseExtents9,
                ShowDatabaseExtentsMetadata4,
                ShowDatabaseExtents10,
                ShowDatabaseExtents11,
                ShowDatabaseExtents12,
                ShowDatabaseExtentsMetadata5,
                ShowDatabaseExtentsPartitioningStatistics,
                ShowDatabaseExtents13,
                ShowDatabaseExtents14,
                ShowDatabaseExtents15,
                ShowDatabaseExtentTagsStatistics,
                ShowDatabaseIdentity,
                ShowDatabaseIngestionMappings,
                ShowDatabaseKeyVaultSecrets,
                ShowDatabaseCslSchema2,
                ShowDatabasePolicies,
                ShowDatabasePrincipals,
                ShowDatabaseSchemaAsCslScript,
                ShowDatabaseSchemaAsJson,
                ShowDatabaseSchemaAsCslScript2,
                ShowDatabaseSchema,
                ShowDatabaseSchemaAsCslScript3,
                ShowDatabaseSchemaAsJson2,
                ShowDatabaseSchemaAsCslScript4,
                ShowDatabaseSchema2,
                ShowDatabaseSchemaViolations,
                ShowDatabaseSchema3,
                DatabaseShardGroupsStatisticsShow,
                ShowDatabaseCslSchema3,
                ShowDatabaseEntity,
                ShowDatabaseExtentContainersCleanOperations,
                ShowDatabaseExtentsMetadata6,
                ShowDatabaseExtents16,
                ShowDatabaseExtents17,
                ShowDatabaseExtents18,
                ShowDatabaseExtentsMetadata7,
                ShowDatabaseExtents19,
                ShowDatabaseExtents20,
                ShowDatabaseExtents21,
                ShowDatabaseExtentsMetadata8,
                ShowDatabaseExtentsPartitioningStatistics2,
                ShowDatabaseExtents22,
                ShowDatabaseExtents23,
                ShowDatabaseExtents24,
                ShowDatabaseIngestionMappings2,
                ShowDatabaseJournal,
                ShowDatabaseCslSchema4,
                ShowDatabasePolicyCaching2,
                ShowDatabasePolicyDiagnostics,
                ShowDatabasePolicyEncoding,
                ShowDatabasePolicyExtentTagsRetention2,
                ShowDatabasePolicyHardRetentionViolations,
                ShowDatabasePolicyIngestionBatching2,
                ShowDatabasePolicyManagedIdentity,
                ShowDatabasePolicyMerge2,
                ShowDatabasePolicyMirroring,
                ShowDatabasePolicyRetention2,
                ShowDatabasePolicySharding2,
                ShowDatabasePolicyShardsGrouping2,
                ShowDatabasePolicySoftRetentionViolations,
                ShowDatabasePolicyStreamingIngestion,
                ShowDatabaseTableMirroringPolicyTemplates,
                ShowDatabasePrincipals2,
                ShowDatabasePrincipalRoles,
                ShowDatabasePurgeOperation,
                ShowDatabaseSchema4,
                ShowDatabaseSchema5,
                ShowDatabaseSchemaViolations2,
                ShowDatabaseSchemaAsCslScript5,
                ShowDatabaseSchemaAsJson3,
                ShowDatabaseSchemaAsCslScript6,
                ShowDatabaseSchema6,
                DatabaseShardGroupsStatisticsShow2,
                ShowDatabase,
                ShowDataOperations,
                ShowDiagnostics,
                ShowEntityGroups,
                ShowEntityGroup,
                ShowEntitySchema,
                ShowExtentContainers,
                ShowExtentCorruptedDatetime,
                ShowExternalTables,
                ShowExternalTableArtifacts,
                ShowExternalTableCslSchema,
                ShowExternalTableCslSchema2,
                ShowExternalTableMappings,
                ShowExternalTableMapping,
                ShowExternalTablePrincipals,
                ShowExternalTablesPrincipalRoles,
                ShowExternalTableSchema,
                ShowExternalTable,
                ShowExternalTable2,
                ShowFabricCache,
                ShowFabricClocks,
                ShowFabricLocks,
                ShowFabric,
                ShowFeatureFlags,
                ShowFollowerDatabase,
                ShowFreshness,
                ShowFunctions,
                ShowFunctionPrincipals,
                ShowFunctionPrincipalRoles,
                ShowFunctionSchemaAsJson,
                ShowFunction,
                ShowFunction2,
                ShowIngestionMappings2,
                ShowIngestionMappings3,
                ShowIngestionMappings4,
                ShowIngestionFailures,
                ShowIngestionMappings5,
                ShowIngestionMappings6,
                ShowIngestionMappings7,
                ShowIngestionMappings8,
                ShowIngestionMappings9,
                ShowIngestionMappings10,
                ShowJournal,
                ShowMaterializedViewsDetails,
                ShowMaterializedViewsDetails2,
                ShowMaterializedViews,
                ShowMaterializedViewCslSchema,
                ShowMaterializedViewDetails,
                ShowMaterializedViewDiagnostics,
                ShowMaterializedViewExtents,
                ShowMaterializedViewFailures,
                ShowMaterializedViewCslSchema2,
                ShowMaterializedViewPolicyCaching,
                ShowMaterializedViewPolicyMerge,
                ShowMaterializedViewPolicyPartitioning,
                ShowMaterializedViewPolicyRetention,
                ShowMaterializedViewPolicyRowLevelSecurity,
                ShowMaterializedViewPrincipals,
                ShowMaterializedViewSchemaAsJson,
                ShowMaterializedViewStatistics,
                ShowMaterializedView,
                ShowMemory,
                ShowMemPools,
                ShowOperations,
                ShowOperationDetails,
                ShowPlugins,
                ShowPrincipalAccess,
                ShowPrincipalRoles,
                ShowPrincipalRoles2,
                ShowQueries,
                ShowQueryExecution,
                ShowQueryPlan,
                ShowQueryCallTree,
                ShowRequestSupport,
                ShowRowStores,
                ShowRowStoreSeals,
                ShowRowStoreTransactions,
                ShowRowStore,
                ShowRunningQueries,
                ShowSchema2,
                ShowServicePoints,
                StoredQueryResultsShow,
                StoredQueryResultShowSchema,
                ShowStreamingIngestionFailures,
                ShowStreamingIngestionStatistics,
                ShowTablesDetails,
                ShowTableExtentsMetadata,
                ShowTableExtents,
                ShowTableExtents2,
                ShowTableExtents3,
                TablesShardGroupsStatisticsShow,
                ShowTables,
                ShowTablesColumnStatistics,
                ShowTablesDetails2,
                TablesShardGroupsStatisticsShow2,
                ShowTables2,
                ShowTableOperationsMirroringStatus,
                ShowTableStarPolicyCaching,
                ShowTableStarPolicyExtentTagsRetention,
                ShowTableStarPolicyIngestionBatching,
                ShowTableStarPolicyIngestionTime,
                ShowTableStarPolicyMerge,
                ShowTableStarPolicyMirroring,
                ShowTableStarPolicyPartitioning,
                ShowTableStarPolicyRestrictedViewAccess,
                ShowTableStarPolicyRetention,
                ShowTableStarPolicyRowLevelSecurity,
                ShowTableStarPolicyRowOrder,
                ShowTableStarPolicySharding,
                ShowTableStarPolicyUpdate,
                ShowTablePolicyAutoDelete,
                ShowTablePolicyCaching,
                ShowTablePolicyEncoding,
                ShowTablePolicyExtentTagsRetention,
                ShowTablePolicyIngestionBatching,
                ShowTablePolicyMerge,
                ShowTablePolicyMirroring,
                ShowTablePolicyPartitioning,
                ShowTablePolicyRestrictedViewAccess,
                ShowTablePolicyRetention,
                ShowTablePolicyRowOrder,
                ShowTablePolicySharding,
                ShowTablePolicyStreamingIngestion,
                ShowTablePolicyUpdate,
                ShowTableRowStoreReferences,
                ShowTableRowStoreSealInfo,
                ShowTableRowStores,
                ShowTableColumnsClassification,
                ShowTableColumnStatitics,
                ShowTableCslSchema,
                ShowTableDataStatistics,
                ShowTableDetails,
                ShowTableDimensions,
                ShowExtentCorruptedDatetime2,
                ShowTableExtentsMetadata2,
                ShowTableExtents4,
                ShowTableExtents5,
                ShowTableExtents6,
                ShowTableIngestionMappings,
                ShowTableIngestionMapping,
                ShowTableCslSchema2,
                ShowTableOperationsMirroringExportedArtifacts,
                ShowTableOperationsMirroringFailures,
                ShowTableOperationsMirroringStatus2,
                ShowTablePolicyIngestionTime,
                ShowTablePolicyRowLevelSecurity,
                ShowTablePrincipals,
                ShowTablePrincipalRoles,
                ShowTableSchemaAsJson,
                TableShardGroupsStatisticsShow,
                TableShardGroupsShow,
                TableShardsGroupMetadataShow,
                TableShardsGroupShow,
                ShowTable,
                ShowTcpConnections,
                ShowTcpPorts,
                ShowThreadPools,
                ShowVersion,
                ShowWorkloadGroups,
                ShowWorkloadGroup,
                ShowExtentDetails,
                ShowExtentDetails2,
                ShowExtentColumnStorageStats,
                ShowExtentDetails3,
                ShowExtentDetails4,
                TableShuffleExtents,
                TableShuffleExtentsQuery,
                UndoDropTable,
                TableDataUpdate,
                TableDataUpdateShortSyntax
            };

            return commandParsers;
        }
    }
}

