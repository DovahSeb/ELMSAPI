using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ELMSAPI.Infrastructure.Extensions;
public static class UlidToStringConverterExtensions
{
    public class UlidToStringConverter : ValueConverter<Ulid, string>
    {
        private static readonly ConverterMappingHints defaultHints = new(size: 26);

        public UlidToStringConverter() : this(null) { }

        public UlidToStringConverter(ConverterMappingHints mappingHints = null) : base(
            convertToProviderExpression: x => x.ToString(),
            convertFromProviderExpression: x => Ulid.Parse(x),
            mappingHints ?? defaultHints)
        { }
    }
}
