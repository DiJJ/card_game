using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope {
    [SerializeField]
    private GameCanvas _gameUI;
    
    protected override void Configure(IContainerBuilder builder) {
        builder.RegisterComponent<IGameUI>(_gameUI);
    }
}
