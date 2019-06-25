using UnityEngine;
using UnityEngine.SceneManagement;

public class BGSizeDeal : Deal
{
    public override void Execute() {
        BGData bgData = GetRequire<BGData>();

        bgData.targetSize += bgData.speed * Time.deltaTime;

        if (bgData.currentSize < bgData.targetSize) {
            bgData.currentSize += bgData.sizeSpeed * Time.deltaTime;
            if (bgData.currentSize > bgData.targetSize) {
                bgData.currentSize = bgData.targetSize;
            }
        }
        else if (bgData.currentSize > bgData.targetSize) {
            bgData.currentSize -= bgData.sizeSpeed * Time.deltaTime;
            if (bgData.currentSize < bgData.targetSize) {
                bgData.currentSize = bgData.targetSize;
            }
        }
        if (bgData.currentSize < 0) {
            bgData.SetSize(0);
        }
        if (bgData.currentSize >= bgData.maxSize) {
            SceneManager.LoadScene("StartScene");
        }
    }
}