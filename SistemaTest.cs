using Xunit;
using System.Collections.Generic;

namespace Parejas
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.AdmitenDescendencia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

       public static IEnumerable<object[]> Data =>
        new List<object[]>
        {       
            new object[] { new Persona("A", 18, 'M') , new Persona("B", 26, 'F'), true},
            new object[] { new Persona("A", 31, 'M') , new Persona("B", 92, 'F'), false},
            new object[] { new Persona("A", 87, 'M') , new Persona("B", 50, 'F'), false},
            new object[] { new Persona("A", 18, 'M') , new Persona("B", 19, 'M'), false},
     
        };
    }
}