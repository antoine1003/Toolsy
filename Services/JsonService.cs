using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Toolsy.Services
{
    public class JsonService
    {
        public static bool isJsonFormatCorrect(string path)
        {
            string schemaJson = @"{
              'type': 'array',
              'items': { '$ref': '#/$defs/tile' },
              '$defs': {
                'tile': {
                  'type': 'object',
                  'required': [ 'name', 'type', 'value' ],
                  'properties': {
                    'name': {
                      'type': 'string',
                    },
                    'type': {
                      'type': 'string',
                      'enum':['link', 'folder', 'file'],
                    },
                    'value': {
                      'type': ['string', 'array'],
                    },
                    'description': {
                      'type': 'string',
                    },
                  }
                }
              }
            }";
            JSchema schema = JSchema.Parse(schemaJson);

            string json = File.ReadAllText(path);

            JArray person;
            try
            {
                person = JArray.Parse(json);
            }
            catch (JsonReaderException)
            {
                return false;
            }

            return person.IsValid(schema);
        }
    }
}
