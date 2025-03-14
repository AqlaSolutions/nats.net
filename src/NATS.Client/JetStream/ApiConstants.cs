// Copyright 2021 The NATS Authors
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at:
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace NATS.Client.JetStream
{
    internal static class ApiConstants
    {
        internal const string AckFloor = "ack_floor";
        internal const string AckPolicy = "ack_policy";
        internal const string AckWait = "ack_wait";
        internal const string Active = "active";
        internal const string AllowRollupHdrs = "allow_rollup_hdrs";
        internal const string AllowDirect = "allow_direct";
        internal const string Api = "api";
        internal const string AuthRequired = "auth_required";
        internal const string AverageProcessingTime = "average_processing_time";        internal const string Backoff = "backoff";
        internal const string Batch = "batch";
        internal const string Bucket = "bucket";
        internal const string Bytes = "bytes";
        internal const string Chunks = "chunks";
        internal const string ClientId = "client_id";
        internal const string ClientIp = "client_ip";
        internal const string Cluster = "cluster";
        internal const string Code = "code";
        internal const string Config = "config";
        internal const string ConnectUrls = "connect_urls";
        internal const string ConsumerCount = "consumer_count";
        internal const string ConsumerSeq = "consumer_seq";
        internal const string Consumers = "consumers";
        internal const string Created = "created";
        internal const string Current = "current";
        internal const string Data = "data";
        internal const string Deleted = "deleted";
        internal const string DeletedDetails = "deleted_details";
        internal const string Deliver = "deliver";
        internal const string DeliverGroup = "deliver_group";
        internal const string DeliverPolicy = "deliver_policy";
        internal const string DeliverSubject = "deliver_subject";
        internal const string Delivered = "delivered";
        internal const string DenyDelete = "deny_delete";
        internal const string DenyPurge = "deny_purge";
        internal const string Description = "description";
        internal const string Dest = "dest";
        internal const string Digest = "digest";
        internal const string Discard = "discard";
        internal const string DiscardNewPerSubject = "discard_new_per_subject";
        internal const string Domain = "domain";
        internal const string Duplicate = "duplicate";
        internal const string DuplicateWindow = "duplicate_window";
        internal const string DurableName = "durable_name";
        internal const string ErrCode = "err_code";
        internal const string Error = "error";
        internal const string Errors = "errors";
        internal const string Expires = "expires";
        internal const string External = "external";
        internal const string Filter = "filter";
        internal const string FilterSubject = "filter_subject";
        internal const string FirstSeq = "first_seq";
        internal const string FirstTs = "first_ts";
        internal const string FlowControl = "flow_control";
        internal const string Go = "go";
        internal const string Hdrs = "hdrs";
        internal const string Headers = "headers";
        internal const string HeadersOnly = "headers_only";
        internal const string Host = "host";
        internal const string Id = "id";
        internal const string IdleHeartbeat = "idle_heartbeat";
        internal const string InactiveThreshold = "inactive_threshold";
        internal const string Internal = "internal";
        internal const string Jetstream = "jetstream";
        internal const string Keep = "keep";
        internal const string Lag = "lag";
        internal const string LameDuckMode = "ldm";
        internal const string LastActive = "last_active";
        internal const string LastBySubject = "last_by_subj";
        internal const string LastError = "last_error";
        internal const string LastSeq = "last_seq";
        internal const string LastTs = "last_ts";
        internal const string Leader = "leader";
        internal const string Limit = "limit";
        internal const string Limits = "limits";
        internal const string Link = "link";
        internal const string Lost = "lost";
        internal const string MaxAckPending = "max_ack_pending";
        internal const string MaxAge = "max_age";
        internal const string MaxBatch = "max_batch";
        internal const string MaxBytes = "max_bytes";
        internal const string MaxBytesRequired = "max_bytes_required";
        internal const string MaxConsumers = "max_consumers";
        internal const string MaxChunkSize = "max_chunk_size";
        internal const string MaxDeliver = "max_deliver";
        internal const string MaxExpires = "max_expires";
        internal const string MaxMemory = "max_memory";
        internal const string MaxMsgSize = "max_msg_size";
        internal const string MaxMsgs = "max_msgs";
        internal const string MaxMsgsPerSubject = "max_msgs_per_subject";
        internal const string MaxPayload = "max_payload";
        internal const string MaxStorage = "max_storage";
        internal const string MaxStreams = "max_streams";
        internal const string MaxWaiting = "max_waiting";
        internal const string Memory = "memory";
        internal const string MemoryMaxStreamBytes = "memory_max_stream_bytes";
        internal const string MemStorage = "mem_storage";
        internal const string Message = "message";
        internal const string Messages = "messages";
        internal const string Mirror = "mirror";
        internal const string MirrorDirect = "mirror_direct";
        internal const string Msgs = "msgs";
        internal const string Name = "name";
        internal const string NextBySubject = "next_by_subj";
        internal const string NoAck = "no_ack";
        internal const string NoErase = "no_erase";
        internal const string Nonce = "nonce";
        internal const string NoWait = "no_wait";
        internal const string Nuid = "nuid";
        internal const string NumAckPending = "num_ack_pending";
        internal const string NumDeleted = "num_deleted";
        internal const string NumErrors = "num_errors";
        internal const string NumPending = "num_pending";
        internal const string NumRedelivered = "num_redelivered";
        internal const string NumReplicas = "num_replicas";
        internal const string NumRequests = "num_requests";
        internal const string NumSubjects = "num_subjects";
        internal const string NumWaiting = "num_waiting";
        internal const string Offline = "offline";
        internal const string Offset = "offset";
        internal const string Options = "options";
        internal const string OptStartSeq = "opt_start_seq";
        internal const string OptStartTime = "opt_start_time";
        internal const string Placement = "placement";
        internal const string ProcessingTime = "processing_time";
        internal const string Republish = "republish";
        internal const string Port = "port";
        internal const string Proto = "proto";
        internal const string Purged = "purged";
        internal const string PushBound = "push_bound";
        internal const string RateLimitBps = "rate_limit_bps";
        internal const string ReplayPolicy = "replay_policy";
        internal const string Replica = "replica";
        internal const string Replicas = "replicas";
        internal const string Request = "request";
        internal const string Response = "response";
        internal const string Retention = "retention";
        internal const string SampleFreq = "sample_freq";
        internal const string Schema = "schema";
        internal const string Sealed = "sealed";
        internal const string Seq = "seq";
        internal const string ServerId = "server_id";
        internal const string ServerName = "server_name";
        internal const string Size = "size";
        internal const string Source = "source";
        internal const string Sources = "sources";
        internal const string Src = "src";
        internal const string Started = "started";
        internal const string State = "state";
        internal const string Stats = "stats";
        internal const string Storage = "storage";
        internal const string StorageMaxStreamBytes = "storage_max_stream_bytes";
        internal const string StreamName = "stream_name";
        internal const string StreamSeq = "stream_seq";
        internal const string Stream = "stream";
        internal const string Streams = "streams";
        internal const string Subject = "subject";
        internal const string Subjects = "subjects";
        internal const string SubjectsFilter = "subjects_filter";
        internal const string Success = "success";
        internal const string Tags = "tags";
        internal const string TemplateOwner = "template_owner";
        internal const string Tiers = "tiers";
        internal const string Time = "time";
        internal const string Tls = "tls_required";
        internal const string Total = "total";
        internal const string Type = "type";
        internal const string Version = "version";
    }
}
