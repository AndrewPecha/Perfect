﻿using MassTransit;
using Perfect.Messages.Commands;

namespace Perfect.AnalyzerService.Infrastructure.Consumers;

public class AnalyzeFileConsumer : IConsumer<AnalyzeFileCommand>
{
    public Task Consume(ConsumeContext<AnalyzeFileCommand> context)
    {
        throw new NotImplementedException();
    }
}