using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hp = 1;  // �u���b�N��HP
    // �u���b�N���q�b�g�������ɕ\������}�e���A��
    public Material hitMaterial;

    // �u���b�N�̃f�t�H���g�̃}�e���A��
    private Material defaultMaterial;   

    // Start is called before the first frame update
    void Start()
    {
        // �u���b�N�̃f�t�H���g�̃}�e���A�����擾
        defaultMaterial = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnter�̓R���C�_�[�ɑ��̃I�u�W�F�N�g�������������ɌĂяo�����
    // �����ɂ͓����������̃I�u�W�F�N�g������
    private void OnCollisionEnter(Collision collision)
    {
        // �q�b�g������q�b�g�}�e���A���ɐ؂�ւ���0.1�b��Ɍ��ɖ߂�
        StartCoroutine(Grow());

        // �u���b�N��HP�����炷
        hp--;

        // HP��0�ȉ��ɂȂ�����u���b�N���폜
        if (hp <= 0)
        {
            Destroy(gameObject);    // �u���b�N���폜
        }
    }

    // �q�b�g������}�e���A����؂�ւ���
    private IEnumerator Grow()
    {
        // �q�b�g�}�e���A���ɐؑ�
        GetComponent<Renderer>().material = hitMaterial;
        // 0.1�b�҂�
        yield return new WaitForSeconds(0.1f);
        // �f�t�H���g�}�e���A���ɖ߂�
        GetComponent<Renderer>().material = defaultMaterial;        
    }
}
