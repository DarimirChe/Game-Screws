using Unity.VisualScripting;
using UnityEngine;

public class HingeJointFinder : MonoBehaviour
{
   // у доски есть два джоинта для двух болтов
   // нужно из скрипта SelectScrew достать название болта который вывинчен и передать в эту переменную

    public string connectedBodyName; // Name of the connected body

    //функция для нахождения того HingeJoint`a который нам нужен
    void FindHingeJointByConnectedBodyName(string connectedBodyName)
    {
        GameObject connectedObject = GameObject.Find(connectedBodyName);

        if (connectedObject != null)
        {
            HingeJoint[] hingeJoints = connectedObject.GetComponents<HingeJoint>();

            foreach (HingeJoint hingeJoint in hingeJoints)
            {
                if (hingeJoint.connectedBody.name == connectedBodyName)
                {

                    //если названия болтов совпадают, тогда нам надо уничтожить
                    //именно этот hingeJoint именно с этим болтом в connected body 
                    //и тогда пластинка будет крутиться только на втором болте
                    Destroy(gameObject.GetComponent("HingeJoint"));

                }
            }
        }
        //тк болтов два, то можно еще завести переменную с количеством болтов
        //чтобы если один болт уже был вывинчен, то не приходилось искать имя, а сразу удалять компонент

    }
}