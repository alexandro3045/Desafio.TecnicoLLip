/* eslint-disable no-useless-constructor */
/* eslint-disable react/require-render-return */
/* eslint-disable import/no-anonymous-default-export */
import React from 'react';
import {
  TreeList, Editing, Column, ValidationRule, Lookup, Button,
} from 'devextreme-react/tree-list';
import { employees } from '../common/employees.js';
const expandedRowKeys = [1];

const popupOptions = {
  title: 'Employee Info',
  showTitle: true,
  width: 700,
};

const lookupData = {
  store: employees,
  sort: 'Full_Name',
};

export default () => {
  
  const onEditorPreparing = (e) => {
    if (e.dataField === 'Head_ID' && e.row.data.ID === 1) {
      e.editorOptions.disabled = true;
      e.editorOptions.value = null;
    }
  };

  const onInitNewRow = (e) => {
    e.data.Head_ID = 1;
  }

  return (
    <div className="card">
       <TreeList
          dataSource={employees}
          columnAutoWidth={true}
          showRowLines={true}
          showBorders={true}
          defaultExpandedRowKeys={expandedRowKeys}
          keyExpr="ID"
          parentIdExpr="Head_ID"
          onEditorPreparing={onEditorPreparing}
          onInitNewRow={onInitNewRow}
        >
          <Editing 
          allowUpdating={true} 
          allowDeleting={true} 
          allowAdding={true} 
          popup={popupOptions} 
          mode="popup" />

          <Column dataField="Full_Name">
            <ValidationRule type="required" />
          </Column>

          <Column dataField="Prefix" caption="Title">
            <ValidationRule type="required" />
          </Column>

          <Column visible={false} dataField="Head_ID" caption="Head">
            <Lookup dataSource={lookupData} valueExpr="ID" displayExpr="Full_Name" />
            <ValidationRule type="required" />
          </Column>

          <Column dataField="Title" caption="Position">
            <ValidationRule type="required" />
          </Column>

          <Column width={150} dataField="City">
            <ValidationRule type="required" />
          </Column>

          <Column width={120} dataField="Hire_Date" dataType="date">
            <ValidationRule type="required" />
          </Column>

          <Column type="buttons">
            <Button name="edit" />
            <Button name="delete" />
            <Button name="add" />
          </Column>
        </TreeList>
    </div>
  )
}