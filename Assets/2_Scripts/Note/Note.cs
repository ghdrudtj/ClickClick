using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
    [SerializeField] private Sprite appleSprite;
    [SerializeField] private Sprite blueberrySprite;
    private bool isApple;
   

    public void SetSprite(bool isApple)
    {
        this.isApple = isApple;
        SpriteRenderer.sprite = isApple ? appleSprite : blueberrySprite;
    }

    public void DeleteNote()
    {
        
        GameManger.lnstance.CalculateScore(isApple);
        noteAnim.Instance.NotesAnim(isApple);
        
        Destroy();
        if (GameManger.score > GameManger.bestScore)
        {
            GameManger.bestScore = GameManger.score;
        }
    }
    
    public void Destroy()
    {
        GameObject.Destroy(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
