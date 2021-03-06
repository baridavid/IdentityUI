﻿using Microsoft.Extensions.Options;
using SSRD.Audit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSRD.Audit.Services
{
    public class DefaultAuditSubjectService : IAuditSubjectDataService
    {
        protected readonly AuditOptions _auditOptions;

        public DefaultAuditSubjectService(IOptions<AuditOptions> auditOptions)
        {
            _auditOptions = auditOptions.Value;
        }

        public virtual AuditSubjectData Get()
        {
            AuditSubjectData auditSubjectData = new AuditSubjectData(
                subjectType: Data.SubjectTypes.Machine,
                subjectIdentifier: _auditOptions.DefaultSubjectName,
                host: null,
                remoteIp: null,
                resourceName: null,
                userAgent: null,
                traceIdentifier: null,
                appVersion: null);

            return auditSubjectData;
        }
    }
}
