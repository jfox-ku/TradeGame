using System;
using EditModeTests.Mocks;
using NUnit.Framework;
using TradeGameNamespace.RuntimeState;

namespace EditModeTests
{
    public class RuntimeStateTests
    {
        private static RuntimeStateID MockStateID => (RuntimeStateID)9999;
        
        [Test]
        public void AddRuntimeState_GivenRuntimeState_ShouldAdd()
        {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();
            var runtimeState = new MockRuntimeState(MockStateID);

            // Act
            runtimeStateHandlerSystem.AddRuntimeState(runtimeState);

            // Assert
            Assert.IsTrue(runtimeStateHandlerSystem.HasRuntimeState(MockStateID));
            Assert.AreEqual(runtimeState, runtimeStateHandlerSystem.GetRuntimeState(MockStateID));
        }
        
        [Test]
        public void RemoveRuntimeState_GivenRuntimeState_ShouldRemove()
        {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();
            var runtimeState = new MockRuntimeState(MockStateID);
            runtimeStateHandlerSystem.AddRuntimeState(runtimeState);

            // Act
            runtimeStateHandlerSystem.RemoveRuntimeState(MockStateID);

            // Assert
            Assert.IsFalse(runtimeStateHandlerSystem.HasRuntimeState(MockStateID));
            Assert.IsNull(runtimeStateHandlerSystem.GetRuntimeState(MockStateID));
        }
        
        [Test]
        public void HasRuntimeState_GivenExistingState_ShouldReturnTrue()
        {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();
            var runtimeState = new MockRuntimeState(MockStateID);
            runtimeStateHandlerSystem.AddRuntimeState(runtimeState);

            // Act
            bool hasState = runtimeStateHandlerSystem.HasRuntimeState(MockStateID);

            // Assert
            Assert.IsTrue(hasState);
        }
        
        [Test]
        public void GetRuntimeState_GivenExistingState_ShouldReturnState()
        {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();
            var runtimeState = new MockRuntimeState(MockStateID);
            runtimeStateHandlerSystem.AddRuntimeState(runtimeState);

            // Act
            var retrievedState = runtimeStateHandlerSystem.GetRuntimeState(MockStateID);

            // Assert
            Assert.IsNotNull(retrievedState);
            Assert.AreEqual(runtimeState, retrievedState);
        }
        
        [Test]
        public void GetRuntimeState_GivenNonExistingState_ShouldReturnNull()
        {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();

            // Act
            var retrievedState = runtimeStateHandlerSystem.GetRuntimeState(MockStateID);

            // Assert
            Assert.IsNull(retrievedState);
        }
        
        [Test]
        public void AddRuntimeState_WhenStateAlreadyExists_ShouldThrowException()
        {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();
            var runtimeState = new MockRuntimeState(MockStateID);
            runtimeStateHandlerSystem.AddRuntimeState(runtimeState);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => runtimeStateHandlerSystem.AddRuntimeState(runtimeState));
        }

        [Test]
        public void RemoveRuntimeState_WhenStateDoesNotExist_ShouldThrowException() {
            // Arrange
            var runtimeStateHandlerSystem = new RuntimeStateSystem();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => runtimeStateHandlerSystem.RemoveRuntimeState(MockStateID));
        }
    }    
}