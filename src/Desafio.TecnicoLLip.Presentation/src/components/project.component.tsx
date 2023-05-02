import { Component } from "react";
import { Formik, Field, Form, ErrorMessage } from "formik";
import * as Yup from "yup";

import ProjectService from "../services/project.service";

type Props = {};

type State = {
  id: number,
  titulo: string,
  descricao: string,
  datacriacao: Date,
  successful: boolean,
  message: string
};

export default class Project extends Component<Props, State> {
  constructor(props: Props) {
    super(props);

    this.handleRegister = this.handleRegister.bind(this);

    this.state = {
      id: 0, 
      titulo: "",
      descricao: "",
      datacriacao: new Date(),
      successful: false,
      message: ""
    };
  }

  validationSchema() {
    return Yup.object().shape({
        titulo: Yup.string()
        .test(
          "len",
          "O título deve ter entre 1 e 100 caracteres.",
          (val: any) =>
            val &&
            val.toString().length >= 1 &&
            val.toString().length <= 100
        )
        .required("Este campo é obrigatório!"),
        descricao: Yup.string()
        .test(
            "len",
            "A descrição deve ter entre 1 e 600 caracteres.",
            (val: any) =>
                val &&
                val.toString().length >= 1 &&
                val.toString().length <= 600
        )
        .required("Este campo é obrigatório!"),
        datacriacao: Yup.date().required("Campo obrigatório"),
    });
  }

  handleRegister(formValue: { id: number, titulo: string; descricao: string; datacriacao: Date }) {
        const { id, titulo, descricao, datacriacao } = formValue;

    this.setState({
      message: "",
      successful: false
    });

   ProjectService.register(
      id,
      titulo,
      descricao,
      datacriacao
    ).then(
      response => {
        this.setState({
          message: response.data.message,
          successful: true
        });
      },
      error => {
        const resMessage =
          (error.response &&
            error.response.data &&
            error.response.data.message) ||
          error.message ||
          error.toString();

        this.setState({
          successful: false,
          message: resMessage
        });
      }
    );
  }

  render() {
    const { successful, message } = this.state;

    const initialValues = {
      id: 0,
      titulo: "",
      descricao:"",
      datacriacao: new Date(),
    };

    return (
      <div className="col-md-12">
        <div className="card card-container">
          
          <Formik
            initialValues={initialValues}
            validationSchema={this.validationSchema}
            onSubmit={this.handleRegister}
          >
            <Form>
              {!successful && (
                <div>
                  <div className="form-group">
                    <label htmlFor="titulo"> Título </label>
                    <Field name="titulo" type="text" className="form-control" />
                    <ErrorMessage
                      name="titulo"
                      component="div"
                      className="alert alert-danger"
                    />
                  </div>

                  <div className="form-group">
                    <label htmlFor="descricao"> Descrição </label>
                    <Field 
                       name="descricao" 
                       type="text" 
                       className="form-control" 
                    />
                    <ErrorMessage
                      name="descricao"
                      component="div"
                      className="alert alert-danger"
                    />
                  </div>

                  <div className="form-group">
                    <label htmlFor="datacriacao"> Data de criacção </label>
                    <Field
                      name="datacriacao"
                      type="Date"
                      className="form-control"
                    />
                    <ErrorMessage
                      name="datacriacao"
                      component="div"
                      className="alert alert-danger"
                    />
                  </div>

                  <div className="form-group">
                    <button type="submit" className="btn btn-primary btn-block">Sign Up</button>
                  </div>
                </div>
              )}

              {message && (
                <div className="form-group">
                  <div
                    className={
                      successful ? "alert alert-success" : "alert alert-danger"
                    }
                    role="alert"
                  >
                    {message}
                  </div>
                </div>
              )}
            </Form>
          </Formik>
        </div>
      </div>
    );
  }
}
