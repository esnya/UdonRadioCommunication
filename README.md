# UdonRadioCommunication
Simplified radio communication system for VRChat Udon worlds.

## Usage
- Place `Transmitter`s and `Receiver`s wherever you want.
- Call custom events `_Activate` and `_Deactivate` and set variable `frequency` by player interactions.
- Add a single `UdonRadioCommunication` to the scene.
- Press "Search URC Components" button in the inspector.
  - Press it when you add or remove `Transmitter`s or `Receiver`s.

For more usage such as `Transceiver`, open a scene `Demo.unity`.


## Runtime Overhead
Only one udon is using the `Update` loop. If the number of `Transmitters` is `Nt`, the number of `Receivers` is `Nr`, and the number of `Players` is `Np`, the computational complexity is `O(Np(Nt+Nr))`.
