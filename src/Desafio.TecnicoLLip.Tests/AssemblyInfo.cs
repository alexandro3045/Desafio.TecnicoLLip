using Xunit;
using Xunit.Extensions.Ordering;

using Finjan.Integracao.Dynamics.Tests.Model;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestFramework("Xunit.Extensions.Ordering.TestFramework", "Xunit.Extensions.Ordering")]
[assembly: TestCaseOrderer("Xunit.Extensions.Ordering.TestCaseOrderer", "Xunit.Extensions.Ordering")]
[assembly: TestCollectionOrderer("Xunit.Extensions.Ordering.CollectionOrderer", "Xunit.Extensions.Ordering")]

[assembly: AssemblyFixture(typeof(Retorno))]
[assembly: AssemblyFixture(typeof(TestingConfiguration))]
[assembly: AssemblyFixture(typeof(Token))]